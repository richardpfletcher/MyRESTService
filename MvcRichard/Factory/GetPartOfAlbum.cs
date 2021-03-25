using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Routing;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MvcRichard.Factory
{
    public class GetPartOfAlbum
    {

        private void LogEntry(string text)
        {
            //var folder = @"C:\Users\Richard\Google Drive\projects\SlideShow\WebApplication2\App_Data";
            var folder = @"C:\Users\Richard\Google Drive\WebSites\EvolutionDeploy\App_Data";
            var logfilename = $@"{folder}\logs.txt";
            if (System.IO.Directory.Exists(folder))
                System.IO.File.AppendAllText(logfilename, $"{System.DateTime.Now}\t{text}\r\n");
        }

        public response Get(int category)
        {

            var dataTable = new DataTable();
            dataTable = new DataTable { TableName = "Album" };
            //var conString1 = ConfigurationManager.ConnectionStrings["LocalEvolution"];
            //string connString = conString1.ConnectionString;
            string connString = URLInfo.GetDataBaseConnectionString();

            System.IO.StringWriter writer = new System.IO.StringWriter();
            string returnString = "";
            response response = new response();
            response.result = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("GetPartOfAlbum", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = category;
                    con.Open();
                    var dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                    dataTable.WriteXml(writer, XmlWriteMode.WriteSchema, false);
                    returnString = writer.ToString();
                    int numberOfRecords = dataTable.Rows.Count;
                    response.result = numberOfRecords;



                    CategoryList list = new CategoryList();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        category myprod = new category();
                        myprod.ID = row["ID"].ToString();
                        myprod.Category = row["Category"].ToString();


                        list.categoryLists.Add(myprod);
                    }
                    response.AddCategoryList(list);

                    response.log.Add(numberOfRecords + " Records found");

                }
            }
            return response;
        }

        public response GetAll(int category,int theme)
        {
            try
            {

                //LogEntry("Theme"+theme);
                //LogEntry("category" + category);

                var dataTable = new DataTable();
            dataTable = new DataTable { TableName = "Album" };
            //var conString1 = ConfigurationManager.ConnectionStrings["LocalEvolution"];
            //string connString = conString1.ConnectionString;
            string connString = URLInfo.GetDataBaseConnectionString();

            System.IO.StringWriter writer = new System.IO.StringWriter();
            string returnString = "";
            response response = new response();
            response.result = 0;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("GetPartOfAlbumAll", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                        if (category != 0)
                        {
                            cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = category;
                        }
                      
                    if (theme!=0)
                        {
                            cmd.Parameters.Add("@Theme", SqlDbType.NVarChar).Value = theme;
                        }

                    con.Open();
                    var dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                    dataTable.WriteXml(writer, XmlWriteMode.WriteSchema, false);
                    returnString = writer.ToString();
                    int numberOfRecords = dataTable.Rows.Count;
                    response.result = numberOfRecords;



                    CategoryListall list = new CategoryListall();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        categoryall catType = new categoryall();



                        catType.RECEIPTNO = row["RECEIPTNO"].ToString();
                        catType.Title = row["Title"].ToString();
                        catType.Picture = row["Picture"].ToString();
                        catType.url = row["url"].ToString();
                        


                        list.categoryListsall.Add(catType);
                    }
                    response.AddCategoryListAll(list);

                    response.log.Add(numberOfRecords + " Records found");

                }

                    return response;


                }

            }
            catch (System.Exception ex)
            {
                LogEntry(ex.ToString());//replace with something like Serilog
                throw;
            }
            
            //return response;
        }

    }
}
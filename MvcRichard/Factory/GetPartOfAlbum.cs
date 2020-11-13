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

    }
}
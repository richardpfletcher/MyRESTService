using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Routing;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System;
//using System.Web.Script.Serialization;

namespace EvolutionWebApi.Factory
{
    public class GetEvolutionSearch
    {

        public GetEvolutionSearch()
        {
        }

        public response Get(string searchString, int theme, int category, int partofalbum, int index, int limit)
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
                using (SqlCommand cmd = new SqlCommand("GetSearchAlbum", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SearchString", SqlDbType.NVarChar).Value = searchString;

                    if (theme >0)
                    {
                        cmd.Parameters.Add("@Theme", SqlDbType.Int).Value = theme;

                    }
                    else
                    {

                        cmd.Parameters.Add("@Theme", SqlDbType.Int).Value = DBNull.Value;
                    }


                    if (category > 0)
                    {
                        cmd.Parameters.Add("@Category", SqlDbType.Int).Value = category;

                    }
                    else
                    {

                        cmd.Parameters.Add("@Category", SqlDbType.Int).Value = DBNull.Value;

                    }

                    if (partofalbum > 0)
                    {
                        cmd.Parameters.Add("@PartOfAlbum", SqlDbType.Int).Value = partofalbum;

                    }
                    else
                    {

                        cmd.Parameters.Add("@PartOfAlbum", SqlDbType.Int).Value = DBNull.Value;

                    }



                    cmd.Parameters.Add("@PageIndex", SqlDbType.Int).Value = index;
                    cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value = limit;
                    con.Open();
                    var dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                    dataTable.WriteXml(writer, XmlWriteMode.WriteSchema, false);
                    returnString = writer.ToString();
                    int numberOfRecords = dataTable.Rows.Count;
                    response.result = numberOfRecords;

                    if (index > 0)
                    {

                        ProductCertificatesList list = new ProductCertificatesList();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            productCertificate myprod = new productCertificate();
                            myprod.ID = row["ID"].ToString();
                            myprod.ShortName = row["ShortName"].ToString();
                            myprod.FullName = row["FullName"].ToString();
                            myprod.HttpPathName = row["HttpPathName"].ToString();
                            myprod.PathName = row["PathName"].ToString();
                            myprod.Category = row["Category"].ToString();
                            myprod.Search = row["Search"].ToString();
                            myprod.PartOfAlbum = row["PartOfAlbum"].ToString();
                            myprod.Albumjpg = row["Albumjpg"].ToString();
                            myprod.Albumpdf = row["Albumpdf"].ToString();
                            myprod.Theme= row["Theme"].ToString();
                            myprod.ThemeName = row["ThemeName"].ToString();
                            response.result = Convert.ToInt16(row["totalRecords"].ToString());


                            list.productCertificates.Add(myprod);
                        }
                        response.AddProductCertificatesList(list);
                    }

                    else
                    {

                        foreach (DataRow row in dataTable.Rows)
                        {

                            response.result = System.Convert.ToInt32(row["totalRecords"]);

                        }

                    }
                    response.log.Add(numberOfRecords + " Records found");
                   
                }
            }
            return response;
        }



        //response response = new response();
        //response.result = 0;
        //ProductCertificatesList list = new ProductCertificatesList();
        //productCertificate myprod = new productCertificate();
        //myprod.accreditation = "CME";
        //myprod.releaseDate = "4/1/2016";
        //myprod.expirtationDate = "4/1/2019";
        //list.productCertificates.Add(myprod);

        //myprod.accreditation = "CNE(ANCC)";
        //myprod.releaseDate = "4/13/2011";
        //myprod.expirtationDate = "12/31/2014";
        //list.productCertificates.Add(myprod);




        //response.AddProductCertificatesList(list);
        //return response;

    //}


    }
}
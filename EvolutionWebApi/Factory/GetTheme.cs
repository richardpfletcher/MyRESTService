using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace EvolutionWebApi.Factory
{
    public class GetTheme
    {

        public response Get()
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
                using (SqlCommand cmd = new SqlCommand("GetTheme", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
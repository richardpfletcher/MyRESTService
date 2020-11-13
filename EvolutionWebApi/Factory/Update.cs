using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace EvolutionWebApi.Factory
{
    public class Update
    {
        public Update()
        {
        }

        public response UpdateTheme(int ID, int theme)
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
                using (SqlCommand cmd = new SqlCommand("UpdateTheme", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Theme", SqlDbType.Int).Value = theme;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    con.Open();
                    var dataReader = cmd.ExecuteReader();
                    dataTable.Load(dataReader);
                    dataTable.WriteXml(writer, XmlWriteMode.WriteSchema, false);
                    returnString = writer.ToString();
                    int numberOfRecords = dataTable.Rows.Count;
                    response.result = 1;
                    response.log.Add(numberOfRecords + " Records found");

                }
            }
            return response;
        }



    }
}
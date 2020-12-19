using System;
using System.Collections.Generic;
using MvcRichard.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcRichard.Factory
{
    public class InsertRecords
    {


        public void loadData(List<DocumentModel> list)
        {
            var conString1 = ConfigurationManager.ConnectionStrings["LocalEvolution"];
            string connString = conString1.ConnectionString;


           



            foreach (var item in list)
            {



                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertAlbum", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = item.FullName;
                        cmd.Parameters.Add("@HttpPathName", SqlDbType.NVarChar).Value = item.HttpPathName;
                        cmd.Parameters.Add("@PathName", SqlDbType.NVarChar).Value = item.PathName;
                        cmd.Parameters.Add("@ShortName", SqlDbType.NVarChar).Value = item.ShortName;

                        //ID Category
                        //1   CD
                        //2   Sayings
                        //3   Talk
                        //4   Books


                        cmd.Parameters.Add("@Category", SqlDbType.Int).Value = 4;

                        // id
                        //part of album It's a beautiful day in the neighboorhood
                        // change this value each time
                        cmd.Parameters.Add("@PartOfAlbum", SqlDbType.Int).Value = 165;


                        con.Open();
                        var dataReader = cmd.ExecuteReader();

                    }

                }
            }

        }
    }
}

 
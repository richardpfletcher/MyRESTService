using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcRichard.Factory
{
    public class URLInfo
    {

        public static string GetDataBaseConnectionString()
        {

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["LocalEvolution"].ToString();
                return connString;

            }

            catch
            {
                return "Data Source=184.168.194.78;Initial Catalog=rfletcher_members;User Id=rfletcher;Password=Barbara_1;";

            }
        }


    }
}
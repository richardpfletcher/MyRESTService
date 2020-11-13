﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EvolutionWebApi.Factory
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
                //return "Data Source=184.168.194.78;Initial Catalog=rfletcher_evolution;User Id=rfletcher;Password=Barbara_1;";
                return "Data Source=(LocalDb)\v11.0;Initial Catalog=rfletcher_evolution;Integrated Security=True;";

            }
        }


    }
}
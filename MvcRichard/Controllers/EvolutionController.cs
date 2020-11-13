using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.ModelBinding;
using System.Web.Routing;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Script.Serialization;
using MvcRichard.Factory;


namespace MvcRichard.Controllers
{
    public class EvolutionController : ApiController
    {

        [HttpGet]
        [Route("api/evolution/")]

        public string Get()
        {

           return "hello";
        }



        [HttpGet]
        [Route("api/evolution/{searchString}/{theme}/{category}/{partofalbum}/{index}/{limit}")]

        //http://localhost:34667/api/evolution/hello


        public response GetByID(string searchString, int theme, int category, int partofalbum, int index, int limit)
        {

            GetEvolutionSearch myGetEvolutionSearch = new GetEvolutionSearch();
            return myGetEvolutionSearch.Get(searchString, theme, category, partofalbum, index, limit);

        }






        public EvolutionController()
        {

        }


    }
}

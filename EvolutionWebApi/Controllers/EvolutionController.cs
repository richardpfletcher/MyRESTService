using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EvolutionWebApi.Factory;
using System.Web.Http.Cors;


namespace EvolutionWebApi.Controllers
{
    //[EnableCors(origins: "http://localhost:34667/", headers: "*", methods: "*")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EvolutionController : ApiController
    {

        /// <summary>
        /// 
        /// hello world
        /// </summary>

        [HttpGet]
        [Route("api/evolution/")]

        //http://localhost:34667/api/evolution/

        public void Get()
        {

            //int i = 0;
        }



        [HttpGet]
        [Route("api/evolution/{searchString}/{theme}/{category}/{partofalbum}/{index}/{limit}")]

        //http://localhost:34667/api/evolution/hello


        public response GetByID(string searchString, int theme,int category,int partofalbum, int index , int limit )
        {

            GetEvolutionSearch myGetEvolutionSearch = new GetEvolutionSearch();
            return myGetEvolutionSearch.Get(searchString, theme,category, partofalbum,index, limit);

        }



    }
}

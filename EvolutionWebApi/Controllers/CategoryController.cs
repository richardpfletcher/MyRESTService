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
    public class CategoryController : ApiController
    {

        /// <summary>
        /// Gets a list for all categorys
        /// 
        /// public response )
        /// 
        /// returns response category
        ///
        /// ID,category
        /// </summary>

        [HttpGet]
        [Route("api/category/")]

        //http://localhost:34667/api/evolution/

        public response Get()
        {

            GetCategory myGetCategory = new GetCategory();
            return myGetCategory.Get();



        }


    }
}

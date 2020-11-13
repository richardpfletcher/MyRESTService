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
    public class ThemeController : ApiController
    {

        [HttpGet]
        [Route("api/theme/")]

        //http://localhost:34667/api/theme/

        public response Get()
        {

            GetTheme myGetTheme = new GetTheme();
            return myGetTheme.Get();



        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcRichard.Factory;

namespace MvcRichard.Controllers
{
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

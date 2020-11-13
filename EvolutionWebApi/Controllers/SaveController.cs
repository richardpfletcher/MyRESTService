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

    public class SaveController : ApiController
    {

        [HttpGet]
        //[HttpPut]
        [Route("api/save/{id}/{theme}")]

        public response Update(int id, int theme)
        {

            Update myUpdate = new Update();
            return myUpdate.UpdateTheme(id, theme);

        }


    }
}

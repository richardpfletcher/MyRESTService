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

    public class PartOfAlbumController : ApiController
    {
        [HttpGet]
        [Route("api/partofalbum/{category}")]

        public response Get(int category)
        {
            GetPartOfAlbum myGetPartOfAlbum = new GetPartOfAlbum();
            return myGetPartOfAlbum.Get(category);
        }

    }
}

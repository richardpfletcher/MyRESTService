using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcRichard.Factory;

namespace MvcRichard.Controllers
{
    public class PartOfAlbumController : ApiController
    {
        [HttpGet]
        [Route("api/partofalbum/{category}/")]

        public response Get(int category)
        {
            GetPartOfAlbum myGetPartOfAlbum = new GetPartOfAlbum();
            return myGetPartOfAlbum.Get(category);
        }

    }
}

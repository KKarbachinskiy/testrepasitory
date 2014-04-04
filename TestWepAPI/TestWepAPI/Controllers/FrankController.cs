using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWepAPI.Controllers
{
    public class FrankController : ApiController
    {
        public string Get()
        {
            return "This is Frank's controller";
        }
    }
}

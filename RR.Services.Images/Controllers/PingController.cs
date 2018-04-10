using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace RR.Services.Images.Controllers
{
    [Route("api/ping")]
    public class PingController : BaseController
    {
        public PingController(ServiceContext context) : base(context)
        {
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            return Ok(JsonConvert.SerializeObject(version));
        }
    }
}

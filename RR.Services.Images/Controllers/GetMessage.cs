using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RR.Services.Images.Models;

namespace RR.Services.Images.Controllers
{
    public class GetMessageController : BaseController
    {
        public GetMessageController(ServiceContext context) : base(context)
        {
        }

        [HttpGet]
        [Route("api/GetMessage/{deviceId}")]
        public IHttpActionResult Get(string deviceId)
        {
            if (ServiceContext.Messages.TryGetValue(deviceId, out Message message))
            {
                return Ok(message);
            }

            return NotFound();
        }
    }
}

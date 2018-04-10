using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RR.Services.Images.Models;

namespace RR.Services.Images.Controllers
{
    public class SaveMessageController : BaseController
    {
        public SaveMessageController(ServiceContext context) : base(context)
        {
        }

        [HttpPost]
        [Route("api/SaveMessage/{deviceId}")]
        public IHttpActionResult Post(string deviceId, [FromBody] Message message)
        {
            if (String.IsNullOrEmpty(message.Contents))
            {
                return BadRequest("'message' cannot be empty");
            }

            ServiceContext.Messages[deviceId] = message;
            return Ok();
        }
    }
}

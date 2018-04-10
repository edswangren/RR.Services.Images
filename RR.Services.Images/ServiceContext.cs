using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

using Message = RR.Services.Images.Models.Message;

namespace RR.Services.Images
{
    public class ServiceContext
    {
        public ILog Logger { get; }
        public ServiceContext()
        {
            Logger = LogManager.GetLogger<ServiceContext>();
        }

        public static Dictionary<string, Message> Messages { get; } = new Dictionary<string, Message>();
    }
}
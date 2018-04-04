using RR.Services.Images.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RR.Services.Images
{
    public class ServiceContext
    {
        public ILogger Logger { get; }
        public ServiceContext(ILogger logger)
        {
            Logger = logger;
        }
    }
}
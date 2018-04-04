using RR.Services.Images.Core;
using RR.Services.Images.Logging;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RR.Services.Images
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
                .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                     "text/html",
                     StringComparison.InvariantCultureIgnoreCase,
                     true,
                     "application/json"));
        }
    }
}

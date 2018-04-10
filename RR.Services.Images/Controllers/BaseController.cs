﻿using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RR.Services.Images.Controllers
{
    public abstract class BaseController : ApiController
    {
        public BaseController(ServiceContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected ServiceContext Context { get; }
    }
}

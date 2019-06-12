﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreCodeCamp.Controllers
{
   [Route("api")]
   public class CampsController : ControllerBase
    {
        public object Get()
        {
            return new { Moniker = "ATL2019", Name = "Code Camp" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myfirstapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ready : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
       
    }
}


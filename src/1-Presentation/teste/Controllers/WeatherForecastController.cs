using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace teste.Controllers
{
    [ApiController]
    [Route("teste")]
    public class WeatherForecastController : ControllerBase
    {
    
        [HttpGet]
        public string Get()
        {
           return "OK";
        }
    }
}

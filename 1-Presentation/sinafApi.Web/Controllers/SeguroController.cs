using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sinafApi.Web.Controllers
{

[ApiController]
[Route("[seguro]")]
public class SeguroController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public SeguroController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

 
}
}

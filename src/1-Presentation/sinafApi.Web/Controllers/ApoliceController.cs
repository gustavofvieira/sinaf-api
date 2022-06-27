using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sinafApi.Web.Controllers
{

[ApiController]
[Route("apolice")]
public class ApoliceController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

   
}
}

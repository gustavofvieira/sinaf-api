using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sinafApi.Web.Controllers
{

[ApiController]
[Route("home")]
public class HomeController : ControllerBase
{

        [HttpGet]
        public ActionResult home()
        {
            return Ok("Sinaf API Ativa.");
        }
    }
}

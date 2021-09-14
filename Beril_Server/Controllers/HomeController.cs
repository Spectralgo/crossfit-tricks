using Microsoft.AspNetCore.Mvc;

namespace Beril_Server.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        // GET
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
    }
}
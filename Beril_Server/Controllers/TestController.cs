using Microsoft.AspNetCore.Mvc;

namespace Beril_Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return Ok("World");
        }
    }
}
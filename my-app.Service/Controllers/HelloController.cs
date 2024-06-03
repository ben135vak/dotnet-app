using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, ben!!!");
        }
        [Route("ben")]
        public IActionResult GetHello()
        {
            return Ok("ALALALALALALALAALAALALALA");
        }
    }
}

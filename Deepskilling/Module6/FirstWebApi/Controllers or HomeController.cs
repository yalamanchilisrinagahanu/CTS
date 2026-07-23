using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to ASP.NET Core 8 Web API");
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("Hello Cognizant Learner!");
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(new
            {
                Name = "First Web API",
                Version = ".NET 8",
                Author = "Student"
            });
        }
    }
}

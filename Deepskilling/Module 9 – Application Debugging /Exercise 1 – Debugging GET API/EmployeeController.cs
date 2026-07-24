using Microsoft.AspNetCore.Mvc;

namespace DebugApi1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var employees = new[]
        {
            new { Id = 1, Name = "Rahul" },
            new { Id = 2, Name = "Priya" }
        };

        return Ok(employees);
    }
}

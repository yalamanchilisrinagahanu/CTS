using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Rahul",
                Department = "IT",
                Salary = 45000
            },
            new Employee
            {
                Id = 2,
                Name = "Priya",
                Department = "HR",
                Salary = 40000
            },
            new Employee
            {
                Id = 3,
                Name = "Kiran",
                Department = "Finance",
                Salary = 55000
            }
        };

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }
    }
}

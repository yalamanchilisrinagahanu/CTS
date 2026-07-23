using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "Rahul", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Priya", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Kiran", Department = "Finance", Salary = 60000 },
            new Employee { Id = 4, Name = "Anitha", Department = "IT", Salary = 55000 }
        };

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // GET: api/Employee/2
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }

        // GET: api/Employee/search?department=IT
        [HttpGet("search")]
        public IActionResult SearchByDepartment(string department)
        {
            var result = employees.Where(e =>
                e.Department.Equals(department, StringComparison.OrdinalIgnoreCase));

            return Ok(result);
        }

        // GET: api/Employee/details?id=1
        [HttpGet("details")]
        public IActionResult GetDetails(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
    }
}

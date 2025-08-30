using Microsoft.AspNetCore.Mvc;
using TimesheetApp.Repositories;
using TimesheetApp.Services;
using TimesheetApp.Models;

namespace TimesheetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpPost("register")]
        public IActionResult Register([FromBody] Employee employee)
        {
            if (_employeeService.GetByEmail(employee.Email) != null)
                return BadRequest("Email already registered");

            var emp = _employeeService.Register(employee);
            return Ok(new { emp.Id, emp.Email, emp.Name });
        }

       
        [HttpPost("login")]
        public IActionResult Login([FromBody] Employee login)
        {
            var user = _employeeService.GetByEmail(login.Email);

            if (user == null || user.Password != login.Password)
                return Unauthorized("Invalid credentials");

            return Ok(new { EmployeeId = user.Id, user.Name, user.Email });
        }

       
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var emp = _employeeService.GetById(id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TimesheetApp.Services;
using TimesheetApp.Models;

namespace TimesheetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimesheetController : ControllerBase
    {
        private readonly ITimesheetService _service;

        public TimesheetController(ITimesheetService service)
        {
            _service = service;
        }

      
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var timesheet = _service.GetById(id);
            if (timesheet == null)
            {
                return NotFound(); 
            }
            return Ok(timesheet); 
        }

        [HttpPost]
        public IActionResult Add([FromBody] Timesheet timesheet)
        {
            if (timesheet == null) return BadRequest("Invalid data");
            var added = _service.AddTimesheet(timesheet);
            return Ok(added);
        }

        [HttpGet("employee/{employeeId}")]
        public IActionResult GetByEmployee(int employeeId)
        {
            return Ok(_service.GetEmployeeTimesheets(employeeId));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Timesheet timesheet)
        {
            var existing = _service.GetById(id);
            if (existing == null) return NotFound();

            existing.Date = timesheet.Date;
            existing.HoursWorked = timesheet.HoursWorked;
            existing.Description = timesheet.Description;
            _service.UpdateTimesheet(existing);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _service.GetById(id);
            if (existing == null) return NotFound();

            _service.DeleteTimesheet(id);
            return NoContent();
        }
    }
}
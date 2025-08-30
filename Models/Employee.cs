using System.ComponentModel.DataAnnotations;

namespace TimesheetApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

       
        public string? Name { get; set; }
        [Required][EmailAddress] 
        public string Email { get; set; }
        [Required] 
        public string Password { get; set; } 

        public virtual ICollection<Timesheet>? Timesheets { get; set; }
    }
}

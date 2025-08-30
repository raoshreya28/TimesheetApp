using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimesheetApp.Models
{
    public class Timesheet
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public DateTime Date { get; set; }
        [Required] 
        public decimal HoursWorked { get; set; }
        public string Description { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}

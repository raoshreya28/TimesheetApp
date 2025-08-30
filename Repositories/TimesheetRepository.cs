using TimesheetApp.Interfaces;
using TimesheetApp.Models;
using TimesheetApp.Data;

namespace TimesheetApp.Repositories
{
    public class TimesheetRepository : ITimesheetRepository
    {
        private readonly AppDbContext _context;

        public TimesheetRepository(AppDbContext context)
        {
            _context = context;
        }

        public Timesheet Add(Timesheet timesheet)
        {
            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();
            return timesheet;
        }

        public IEnumerable<Timesheet> GetByEmployeeId(int employeeId) =>
            _context.Timesheets.Where(t => t.EmployeeId == employeeId).ToList();

        public Timesheet GetById(int id) =>
            _context.Timesheets.FirstOrDefault(t => t.Id == id);

        public void Update(Timesheet timesheet)
        {
            _context.Timesheets.Update(timesheet);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var timesheet = _context.Timesheets.FirstOrDefault(t => t.Id == id);
            if (timesheet != null)
            {
                _context.Timesheets.Remove(timesheet);
                _context.SaveChanges();
            }
        }
    }
}
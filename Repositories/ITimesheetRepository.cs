using TimesheetApp.Models;
using System.Collections.Generic;

namespace TimesheetApp.Interfaces
{
    public interface ITimesheetRepository
    {
        Timesheet Add(Timesheet timesheet);
        IEnumerable<Timesheet> GetByEmployeeId(int employeeId);
        Timesheet GetById(int id);
        void Update(Timesheet timesheet);
        void Delete(int id);
    }
}

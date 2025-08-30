using TimesheetApp.Models;
using System.Collections.Generic;

namespace TimesheetApp.Services
{
    public interface ITimesheetService
    {
        Timesheet AddTimesheet(Timesheet timesheet);
        IEnumerable<Timesheet> GetEmployeeTimesheets(int employeeId);
        Timesheet GetById(int id);
        void UpdateTimesheet(Timesheet timesheet);
        void DeleteTimesheet(int id);
    }
}

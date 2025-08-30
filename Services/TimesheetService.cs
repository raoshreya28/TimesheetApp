using TimesheetApp.Interfaces;
using TimesheetApp.Models;
using System.Collections.Generic;

namespace TimesheetApp.Services
{
    public class TimesheetService : ITimesheetService
    {
        private readonly ITimesheetRepository _repo;

        public TimesheetService(ITimesheetRepository repo)
        {
            _repo = repo;
        }

        public Timesheet AddTimesheet(Timesheet timesheet) =>
            _repo.Add(timesheet);

        public IEnumerable<Timesheet> GetEmployeeTimesheets(int employeeId) =>
            _repo.GetByEmployeeId(employeeId);

        public Timesheet GetById(int id) =>
            _repo.GetById(id);

        public void UpdateTimesheet(Timesheet timesheet) =>
            _repo.Update(timesheet);

        public void DeleteTimesheet(int id) =>
            _repo.Delete(id);
    }
}
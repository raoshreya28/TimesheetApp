using TimesheetApp.Models;

namespace TimesheetApp.Services
{
    public interface IEmployeeService
    {
        Employee Register(Employee employee);
        Employee GetById(int id);
        Employee GetByEmail(string email);
    }
}

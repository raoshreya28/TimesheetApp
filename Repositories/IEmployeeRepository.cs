using TimesheetApp.Models;

namespace TimesheetApp.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee Add(Employee employee);
        Employee GetByEmail(string email);
        Employee GetById(int id);
    }
}

using TimesheetApp.Interfaces;
using TimesheetApp.Models;

namespace TimesheetApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public Employee Register(Employee employee)
        {
            return _employeeRepo.Add(employee);
        }

        public Employee GetById(int id)
        {
            return _employeeRepo.GetById(id);
        }

        public Employee GetByEmail(string email)
        {
            return _employeeRepo.GetByEmail(email);
        }
    }
}

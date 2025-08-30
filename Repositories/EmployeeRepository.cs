using TimesheetApp.Interfaces;
using TimesheetApp.Models;
using TimesheetApp.Data;

namespace TimesheetApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee GetByEmail(string email) =>
            _context.Employees.FirstOrDefault(e => e.Email == email);

        public Employee GetById(int id) =>
            _context.Employees.FirstOrDefault(e => e.Id == id);
    }
}

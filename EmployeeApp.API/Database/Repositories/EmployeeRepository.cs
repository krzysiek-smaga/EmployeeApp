using EmployeeApp.API.Domain.Models;
using EmployeeApp.API.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Database.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeApiDbContext _context;

        public EmployeeRepository(EmployeeApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<string>> GetEmployeesNames()
        {
            return await _context.Employees.Select(emp => emp.Name).ToListAsync();
        }
    }
}

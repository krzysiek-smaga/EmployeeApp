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

        public async Task<IEnumerable<Employee>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId)
        {
            var employees = _context.Employees.AsQueryable();

            if (fromDate != null)
            {
                employees = employees.Where(e => e.HireDate >= fromDate);
            }

            if (toDate != null)
            {
                employees = employees.Where(e => e.HireDate <= toDate);
            }

            if (!string.IsNullOrEmpty(name))
            {
                employees = employees.Where(e => e.Name.Contains(name));
            }

            if (managerId != null)
            {
                employees = employees.Where(e => e.ManagerId == managerId);
            }

            return await employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetManagers()
        {
            var managerIds = await _context.Employees.AsQueryable().Select(x => x.ManagerId).Distinct().ToListAsync();

            var managers = await _context.Employees.AsQueryable().Where(e => managerIds.Contains(e.Id)).ToListAsync();

            return managers;
        }

        public async Task<IEnumerable<string>> GetEmployeesNames()
        {
            return await _context.Employees.Select(emp => emp.Name).ToListAsync();
        }
    }
}

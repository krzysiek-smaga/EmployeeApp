using EmployeeApp.API.Domain.Models;
using EmployeeApp.API.Domain.Repositories;

namespace EmployeeApp.API.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId)
        {
            return await _employeeRepository.GetEmployees(fromDate, toDate, name, managerId);
        }

        public async Task<IEnumerable<Employee>> GetManagers()
        {
            return await _employeeRepository.GetManagers();
        }

        public async Task<IEnumerable<string>> GetEmployeesNames()
        {
            return await _employeeRepository.GetEmployeesNames();
        }
    }
}

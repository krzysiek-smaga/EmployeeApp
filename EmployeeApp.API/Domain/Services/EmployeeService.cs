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

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEmployees();
        }

        public async Task<List<string>> GetEmployeesNames()
        {
            return await _employeeRepository.GetEmployeesNames();
        }
    }
}

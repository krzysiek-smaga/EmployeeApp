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

        public Task<List<Employee>> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }
    }
}

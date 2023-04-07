using EmployeeApp.API.Domain.Models;

namespace EmployeeApp.API.Domain.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }
}

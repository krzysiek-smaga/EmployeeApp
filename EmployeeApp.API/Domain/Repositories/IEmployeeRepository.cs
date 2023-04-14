using EmployeeApp.API.Domain.Models;

namespace EmployeeApp.API.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<List<string>> GetEmployeesNames();
    }
}

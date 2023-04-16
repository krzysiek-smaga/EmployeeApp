using EmployeeApp.API.Domain.Models;

namespace EmployeeApp.API.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId);
        Task<IEnumerable<Employee>> GetManagers();
        Task<IEnumerable<string>> GetEmployeesNames();
    }
}

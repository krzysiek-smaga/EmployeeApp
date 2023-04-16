using EmployeeApp.API.Domain.Models;

namespace EmployeeApp.API.Domain.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId);
        Task<List<Employee>> GetManagers();
        Task<List<string>> GetEmployeesNames();
    }
}

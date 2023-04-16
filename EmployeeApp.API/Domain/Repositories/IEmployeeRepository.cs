using EmployeeApp.API.Domain.Models;

namespace EmployeeApp.API.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId);
        Task<IEnumerable<Employee>> GetManagers();
        Task<IEnumerable<string>> GetEmployeesNames();
    }
}

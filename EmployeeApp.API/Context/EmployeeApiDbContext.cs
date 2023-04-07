using EmployeeApp.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Context
{
    public class EmployeeApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeApiDbContext(DbContextOptions<EmployeeApiDbContext> options) : base(options) { }
    }
}

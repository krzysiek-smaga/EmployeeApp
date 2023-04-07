using EmployeeApp.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Context
{
    public class EmployeeApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeApiDbContext(DbContextOptions<EmployeeApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "CEO", HireDate = DateTime.Now.AddDays(-30), ManagerId = null },
                new Employee { Id = 2, Name = "Director One", HireDate = DateTime.Now.AddDays(-28), ManagerId = 1 },
                new Employee { Id = 3, Name = "Director Two", HireDate = DateTime.Now.AddDays(-26), ManagerId = 1 },
                new Employee { Id = 4, Name = "Manager One", HireDate = DateTime.Now.AddDays(-24), ManagerId = 2 },
                new Employee { Id = 5, Name = "Manager Two", HireDate = DateTime.Now.AddDays(-22), ManagerId = 2 },
                new Employee { Id = 6, Name = "Manager Three", HireDate = DateTime.Now.AddDays(-20), ManagerId = 3 },
                new Employee { Id = 7, Name = "Regular Employee One", HireDate = DateTime.Now.AddDays(-18), ManagerId = 4 },
                new Employee { Id = 8, Name = "Regular Employee Two", HireDate = DateTime.Now.AddDays(-15), ManagerId = 4 },
                new Employee { Id = 9, Name = "Regular Employee Three", HireDate = DateTime.Now.AddDays(-12), ManagerId = 4 },
                new Employee { Id = 10, Name = "Regular Employee Four", HireDate = DateTime.Now.AddDays(-9), ManagerId = 5 },
                new Employee { Id = 11, Name = "Regular Employee Five", HireDate = DateTime.Now.AddDays(-6), ManagerId = 5 },
                new Employee { Id = 12, Name = "Regular Employee Six", HireDate = DateTime.Now.AddDays(-3), ManagerId = 6 }
                );
        }
    }
}

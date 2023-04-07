namespace EmployeeApp.API.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public int? ManagerId { get; set; }
    }
}

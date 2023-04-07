using EmployeeApp.API.Context;
using EmployeeApp.API.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeApiDbContext _context;

        public EmployeesController(EmployeeApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}

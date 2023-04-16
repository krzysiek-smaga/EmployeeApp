using EmployeeApp.API.Domain.Models;
using EmployeeApp.API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeSerivce)
        {
            _employeeService = employeeSerivce;
        }

        [HttpGet("GetEmployees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees(DateTime? fromDate, DateTime? toDate, string? name, int? managerId)
        {
            return Ok(await _employeeService.GetEmployees(fromDate, toDate, name, managerId));
        }

        [HttpGet("GetManagers")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetManagers()
        {
            return Ok(await _employeeService.GetManagers());
        }

        [HttpGet("GetEmployeesNames")]
        public async Task<ActionResult<IEnumerable<string>>> GetEmployeesNames()
        {
            return Ok(await _employeeService.GetEmployeesNames());
        }
    }
}

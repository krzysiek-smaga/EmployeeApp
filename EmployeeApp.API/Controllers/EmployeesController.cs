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
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            return Ok(await _employeeService.GetEmployees());
        }

        [HttpGet("GetEmployeesNames")]
        public async Task<ActionResult<List<string>>> GetEmployeesNames()
        {
            return Ok(await _employeeService.GetEmployeesNames());
        }
    }
}

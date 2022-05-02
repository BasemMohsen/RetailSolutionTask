using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailSolution.Services.EmployeeService;
using RetailSoultion.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployee/{id}")]
        public async Task<ActionResult> GetEmployee(Guid id)
        {
            var employee = await _employeeService.GetEmployee(id);
            return Ok(employee);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = await _employeeService.AddEployee(employeeDto);
            return Ok(employee);
        }

        [HttpPost("AddEmployeeWorkHours")]
        public async Task<ActionResult> AddEmployeeWorkHours(EmployeeTimeLogDto employeeTimeLogDto)
        {
            var employee = await _employeeService.AddEployeeWorkHours(employeeTimeLogDto);
            return Ok(employee);
        }

        [HttpGet("WorkHoursReport/{id}")]
        public async Task<ActionResult> WorkHoursReport(Guid id)
        {
            var employee = await _employeeService.WorkHoursReport(id);
            return Ok(employee);
        }
    }
}

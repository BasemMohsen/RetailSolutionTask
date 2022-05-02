using RetailSoultion.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailSolution.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetEmployee(Guid id);
        Task<bool> AddEployee(EmployeeDto employeeDto);
        Task<bool> AddEployeeWorkHours(EmployeeTimeLogDto employeeTimeLogDto);
        Task<List<EmployeeTimeLogDto>> WorkHoursReport(Guid id);
    }
}

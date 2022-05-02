using RetailSoultion.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailSolution.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<ApiResponse> GetEmployee(Guid id);
        Task<ApiResponse> AddEployee(EmployeeDto employeeDto);
        Task<ApiResponse> AddEployeeWorkHours(EmployeeTimeLogDto employeeTimeLogDto);
        Task<ApiResponse> WorkHoursReport(Guid id);
    }
}

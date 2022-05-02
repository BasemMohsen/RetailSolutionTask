using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RetailSoultion.Domain.Dto;
using RetailSoultion.Entities;


namespace RetailSoultion.Domain.Abstraction
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(Guid id);
        Task<bool> AddEmployee(Employee employee);
        Task<bool> AddEmployeeWorkHours(EmployeeTimeLog employeeTimeLog);
        Task<List<EmployeeTimeLog>> WorkHoursReport(Guid id);
    }
}

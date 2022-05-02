using Microsoft.EntityFrameworkCore;
using RetailSoultion.DAL.DataContext;
using RetailSoultion.Domain.Abstraction;
using RetailSoultion.Domain.Dto;
using RetailSoultion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSoultion.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RetailSolutionContext _context;
        public EmployeeRepository(RetailSolutionContext context)
        {
            _context = context;
        }

        public async Task<bool> AddEmployee(Employee employee)
        {
            try
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddEmployeeWorkHours(EmployeeTimeLog employeeTimeLog)
        {
            try
            {
                await _context.EmployeeTimeLogs.AddAsync(employeeTimeLog);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Employee> GetEmployee(Guid id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(c=> c.Id == id);
            return employee;
        }

        public async Task<List<EmployeeTimeLog>> WorkHoursReport(Guid id)
        {
            var employeeTimeLogs = await _context.EmployeeTimeLogs.Include(c=> c.Employee).Where(c => c.EmployeeId == id).ToListAsync();
            return employeeTimeLogs;
        }
    }
}

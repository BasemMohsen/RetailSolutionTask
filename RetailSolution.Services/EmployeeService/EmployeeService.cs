using AutoMapper;
using RetailSoultion.Domain.Abstraction;
using RetailSoultion.Domain.Dto;
using RetailSoultion.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailSolution.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            var result = await _employeeRepository.AddEmployee(employee);

            return new ApiResponse()
            {
                Data = result,
                Status = "true",
                Message = "Success"
            };
        }

        public async Task<ApiResponse> AddEmployeeWorkHours(EmployeeTimeLogDto employeeTimeLogDto)
        {
            var employeeTimeLog = _mapper.Map<EmployeeTimeLog>(employeeTimeLogDto);
            var result = await _employeeRepository.AddEmployeeWorkHours(employeeTimeLog);

            return new ApiResponse()
            {
                Data = result,
                Status = "true",
                Message = "Success"
            };
        }

        public async Task<ApiResponse> GetEmployee(Guid id)
        {
            var empployee = await _employeeRepository.GetEmployee(id);

            var employeeDto = _mapper.Map<EmployeeDto>(empployee);
            
            return new ApiResponse()
            {
                Data = employeeDto,
                Status = "true",
                Message = "Success"
            };
        }

        public async Task<ApiResponse> WorkHoursReport(Guid id)
        {
            var report = await _employeeRepository.WorkHoursReport(id);

            var reportDto =  _mapper.Map<List<EmployeeTimeLogDto>>(report);

            foreach (var item in reportDto)
            {
                if (item.IsNightShift)
                {
                    int breakPerHour = ((int)item.WorkHours) * 15;
                    int breakperDay = ((int)item.WorkHours / 4) * 30;

                    item.BreakInMinutes = breakperDay + breakPerHour;
                }

                else
                {
                    int breakPerHour = ((int)item.WorkHours) * 10;
                    int breakperDay = ((int)item.WorkHours / 4) * 15;

                    item.BreakInMinutes = breakperDay + breakPerHour;
                }
            }

            return new ApiResponse()
            {
                Data = reportDto,
                Status = "true",
                Message = "Success"
            };
        }
    }
}

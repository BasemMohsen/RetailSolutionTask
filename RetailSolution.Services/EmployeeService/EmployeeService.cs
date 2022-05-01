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

        public async Task<bool> AddEployee(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            var result = await _employeeRepository.AddEmployee(employee);
            return result;
        }

        public async Task<EmployeeDto> GetEmployee(Guid id)
        {
            var empployee = await _employeeRepository.GetEmployee(id);

            var employeeDto = _mapper.Map<EmployeeDto>(empployee);
            return employeeDto;
        }
    }
}

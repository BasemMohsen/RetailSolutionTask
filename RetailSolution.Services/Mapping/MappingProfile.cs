using AutoMapper;
using RetailSoultion.Domain.Dto;
using RetailSoultion.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSolution.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}

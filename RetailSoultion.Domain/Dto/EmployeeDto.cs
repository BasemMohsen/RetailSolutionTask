using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSoultion.Domain.Dto
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
}

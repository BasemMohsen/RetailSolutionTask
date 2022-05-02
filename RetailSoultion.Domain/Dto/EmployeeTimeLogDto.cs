using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSoultion.Domain.Dto
{
    public class EmployeeTimeLogDto
    {
        public Guid Id { get; set; }
        public EmployeeDto Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Day { get; set; }
        public float WorkHours { get; set; }
        public bool IsNightShift { get; set; }
        public int BreakInMinutes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RetailSoultion.Entities
{
    public class EmployeeTimeLog
    {
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        [Required]
        public DateTime Day { get; set; }
        [Required]
        public float WorkHours { get; set; }
        public bool IsNightShift { get; set; } = false;
    }
}

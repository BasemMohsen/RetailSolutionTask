using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSoultion.Domain.Dto
{
    public class ApiResponse
    {
        public string Message { get; set; }

        public string Status { get; set; }

        public Object Data { get; set; }
    }
}

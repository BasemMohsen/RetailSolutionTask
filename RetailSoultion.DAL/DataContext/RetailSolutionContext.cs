using Microsoft.EntityFrameworkCore;
using RetailSoultion.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailSoultion.DAL.DataContext
{
    public class RetailSolutionContext : DbContext
    {
        public RetailSolutionContext(DbContextOptions<RetailSolutionContext> options): base(options)
        { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeTimeLog> EmployeeTimeLogs { get; set; }
    }
}

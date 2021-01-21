using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Data
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}

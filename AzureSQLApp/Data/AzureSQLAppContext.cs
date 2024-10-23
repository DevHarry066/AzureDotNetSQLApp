using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureSQLApp.Models;

namespace AzureSQLApp.Data
{
    public class AzureSQLAppContext : DbContext
    {
        public AzureSQLAppContext (DbContextOptions<AzureSQLAppContext> options)
            : base(options)
        {
        }

        public DbSet<AzureSQLApp.Models.Employee> Employees { get; set; } = default!;
        public DbSet<AzureSQLApp.Models.Department> Departments { get; set; } = default!;
    }
}

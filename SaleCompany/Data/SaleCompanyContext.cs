using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleCompany.Models;

namespace SaleCompany.Data
{
    public class SaleCompanyContext : DbContext
    {
        public SaleCompanyContext (DbContextOptions<SaleCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<SaleCompany.Models.seedData> seedData { get; set; }
    }
}

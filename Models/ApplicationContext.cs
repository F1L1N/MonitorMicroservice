using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorMicroservice.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Patient> Users { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

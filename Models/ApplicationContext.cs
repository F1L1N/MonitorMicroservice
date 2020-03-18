using Microsoft.EntityFrameworkCore;
using MonitorMicroservice.Models.Analyzes;
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
        public DbSet<AnalyseBloodBio> AnalyzesBloodBio { get; set; }
        public DbSet<AnalyseBloodClynic> AnalyzesBloodClynic { get; set; }
        public DbSet<AnalyseBloodGroup> AnalyzesBloodGroup { get; set; }
        public DbSet<AnalyseCoprogram> AnalyzesCoprogram { get; set; }
        public DbSet<AnalyseIFA> AnalyzesIFA { get; set; }
        public DbSet<AnalyseUrine> AnalyzesUrine { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

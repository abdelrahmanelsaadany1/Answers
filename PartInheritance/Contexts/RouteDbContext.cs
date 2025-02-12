using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartInheritance.Contexts
{
    internal class RouteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RouteG02;Trusted_Connection=True;TrustServerCertificate=True");
        }
       
        public DbSet<Entities.FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<Entities.PartTime> PartTimes { get; set; }
    }
}

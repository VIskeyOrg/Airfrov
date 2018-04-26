using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TabHolidayCore.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Int64>
    {
       

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           

            builder.Entity<Country>()
                .Property(c => c.Name).HasColumnType("VARCHAR(50)");
            builder.Entity<Country>()
                .Property(c => c.Extention).HasColumnType("VARCHAR(10)");

            
        }

        

        public DbSet<Country> Countries { get; set; }
        
    }
}

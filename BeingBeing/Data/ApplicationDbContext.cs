using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeingBeing.Models;

namespace BeingBeing.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Appetite> Appetite { get; set; }
        public DbSet<Consuming> Consumings { get; set; }
        public DbSet<EmotionalStates> EmotionalStates { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Pills> Pills { get; set; }
        public DbSet<Poop> Poop { get; set; }
        public DbSet<Sickness> Sickness { get; set; }
        public DbSet<Sleep> Sleep { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Weather> Weather { get; set; }
        public DbSet<Working> Working { get; set; }
    }
}

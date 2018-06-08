using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BeingBeing.Models 
{
    public class BeingBeingContext : DbContext
    {
        public BeingBeingContext(DbContextOptions<BeingBeingContext> options)
            : base(options)
        {

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

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
        public DbSet<States> States { get; set; }
        public DbSet<Doings> Doings { get; set; }
    }
}

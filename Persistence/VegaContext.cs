using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persistence
{
    public class VegaContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Feature> Features { get; set; }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./vega.db");
        }*/

        public VegaContext(DbContextOptions<VegaContext> options)
         : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             // add your own confguration here
        }
    }
}
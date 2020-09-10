using Microsoft.EntityFrameworkCore;
using SsmPtvMovil.Common.Entities;

namespace SsmPtvMovil.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<City> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<City> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<State>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<Store>()
            .HasIndex(t => t.Name)
            .IsUnique();

        }

        public DbSet<SsmPtvMovil.Common.Entities.State> State { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using SsmPtvMovil.Common.Entities;

namespace SsmPtvMovil.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
            .HasIndex(t => t.Name)
            .IsUnique();

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Parcial_1.Shared.Entities;

namespace Parcial_1.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Stockist> Stockists { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Stockist>().HasIndex(x => x.ProviderName).IsUnique();
        }
    }
}

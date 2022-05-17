using Alphastellar_WebAPI_Project.Infrastructure.SeedData;
using Alphastellar_WebAPI_Project.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alphastellar_WebAPI_Project.Infrastructure
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarSeeding());
            modelBuilder.ApplyConfiguration(new BusSeeding());
            modelBuilder.ApplyConfiguration(new BoatSeeding());
            base.OnModelCreating(modelBuilder);
        }
    }
}

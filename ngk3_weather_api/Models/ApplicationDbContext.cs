using Microsoft.EntityFrameworkCore;

namespace ngk3_weather_api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WeatherStation> WeatherStations { get; set; }
        public DbSet<WeatherObservation> WeatherObservations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherStation>(entity =>
            {
                entity.HasData(new WeatherStation
                {
                    Latitude = 56.234154,
                    Longitude = 10.238570,
                    Name = "Lystrup",
                    Username = "lystrup1",
                    Password = BCrypt.Net.BCrypt.HashPassword("lystrup1Password")
                });
            });
        }
    }
}
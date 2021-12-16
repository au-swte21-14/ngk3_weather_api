using Microsoft.EntityFrameworkCore;

namespace ngk3_weather_api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public DbSet<WeatherStation> WeatherStations { get; set; }
        public DbSet<WeatherObservation> WeatherObservations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
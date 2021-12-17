using System;
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
                    Id = 1,
                    Latitude = 56.234154,
                    Longitude = 10.238570,
                    Name = "Lystrup",
                    Username = "lystrup1",
                    Password = BCrypt.Net.BCrypt.HashPassword("lystrup1Password")
                });
                entity.HasData(new WeatherStation
                {
                    Id = 2,
                    Latitude = 45.572114,
                    Longitude = 6.829348,
                    Name = "Les Arcs",
                    Username = "lesarcs1",
                    Password = BCrypt.Net.BCrypt.HashPassword("lesarcs1Password")
                });
                entity.HasData(new WeatherStation
                {
                    Id = 3,
                    Latitude = -53.093661,
                    Longitude = 73.527351,
                    Name = "Heard Island & McDonald Islands",
                    Username = "mcd1",
                    Password = BCrypt.Net.BCrypt.HashPassword("mcd1Password")
                });
            });
            
            modelBuilder.Entity<WeatherObservation>(entity =>
            {
                int id = 1;
                
                // Lystrup
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T12:21:08.7181648"),
                    Temperature = new decimal(30.2),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T11:44:05.3258526"),
                    Temperature = new decimal(31),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T11:39:18.2790433"),
                    Temperature = new decimal(34),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
                
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-16T12:21:08.7181648"),
                    Temperature = new decimal(20),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-16T11:44:05.3258526"),
                    Temperature = new decimal(24),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-16T11:39:18.2790433"),
                    Temperature = new decimal(27),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
                
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-18T12:21:08.7181648"),
                    Temperature = new decimal(11),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-18T11:44:05.3258526"),
                    Temperature = new decimal(12),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-18T11:39:18.2790433"),
                    Temperature = new decimal(13),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
                
                
                // Les Arcs
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-17T12:21:08.7181648"),
                    Temperature = new decimal(-30.2),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-17T11:44:05.3258526"),
                    Temperature = new decimal(-31),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-17T11:39:18.2790433"),
                    Temperature = new decimal(-34),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
                
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-16T12:21:08.7181648"),
                    Temperature = new decimal(-20),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-16T11:44:05.3258526"),
                    Temperature = new decimal(-24),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-16T11:39:18.2790433"),
                    Temperature = new decimal(-27),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
                
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-18T12:21:08.7181648"),
                    Temperature = new decimal(-11),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-18T11:44:05.3258526"),
                    Temperature = new decimal(-12),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                });
                entity.HasData(new WeatherObservation
                {
                    Id = id++,
                    WeatherStationId = 2,
                    Date = Convert.ToDateTime("2021-12-18T11:39:18.2790433"),
                    Temperature = new decimal(-13),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                });
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ngk3_weather_api.Controllers;
using ngk3_weather_api.Models;
using NUnit.Framework;

namespace ngk_weather_api.Test
{
    [TestFixture]
    public class WeatherControllerTest
    {
        private WeatherController _weatherController;
        private ApplicationDbContext _dbContext;
        
        [SetUp]
        public void SetUp()
        {
            _dbContext = new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "db")
                .EnableSensitiveDataLogging()
                .Options);
            _weatherController = new WeatherController(_dbContext);
            _dbContext.WeatherObservations.RemoveRange(_dbContext.WeatherObservations);
            _dbContext.WeatherStations.RemoveRange(_dbContext.WeatherStations);
            _dbContext.SaveChanges();
            
            var WeatherStations = new List<WeatherStation>
            {
                new WeatherStation
                {
                    Id = 1,
                    Latitude = 56.234154,
                    Longitude = 10.238570,
                    Name = "Lystrup",
                    Username = "lystrup1",
                    Password = BCrypt.Net.BCrypt.HashPassword("lystrup1Password")
                },
                new WeatherStation
                {
                    Id = 2,
                    Latitude = 45.572114,
                    Longitude = 6.829348,
                    Name = "Les Arcs",
                    Username = "lesarcs1",
                    Password = BCrypt.Net.BCrypt.HashPassword("lesarcs1Password")
                },
                new WeatherStation
                {
                    Id = 3,
                    Latitude = -53.093661,
                    Longitude = 73.527351,
                    Name = "Heard Island & McDonald Islands",
                    Username = "mcd1",
                    Password = BCrypt.Net.BCrypt.HashPassword("mcd1Password")
                }
            };
            var WeatherObservations = new List<WeatherObservation>
            {
                new WeatherObservation
                {
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T12:21:08.7181648"),
                    Temperature = new decimal(30.2),
                    Humidity = 35,
                    Pressure = new decimal(1100.1)
                },
                new WeatherObservation
                {
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T11:44:05.3258526"),
                    Temperature = new decimal(31),
                    Humidity = 19,
                    Pressure = new decimal(1001.2)
                },
                new WeatherObservation
                {
                    WeatherStationId = 1,
                    Date = Convert.ToDateTime("2021-12-17T11:39:18.2790433"),
                    Temperature = new decimal(34),
                    Humidity = 11,
                    Pressure = new decimal(1011.0)
                }
            };

            _dbContext.WeatherObservations.AddRange(WeatherObservations);
            _dbContext.WeatherStations.AddRange(WeatherStations);
            _dbContext.SaveChanges();

        }

        [Test]
        public void GetStations_Test()
        {
            ActionResult<List<WeatherStation>> weatherStations = _weatherController.GetStations();
            Assert.NotNull(weatherStations);
            Assert.AreEqual(3, weatherStations.Value.Count);
        }

        [TestCase("lystrup1")]
        public void GetStation_Username(string username)
        {
            var weatherStaton = _weatherController.GetStation(username);
            Assert.AreEqual(3,weatherStaton.Value.Count);
        }
        
        [Test]
        public void GetStation_Username_Null()
        {
            var weatherStaton = _weatherController.GetStation("Null");
            var notFoundObjectResult = new NotFoundObjectResult(weatherStaton);
            Assert.AreEqual(weatherStaton, notFoundObjectResult.Value);
        }

        [Test]
        public void GetStation_UserName_Date_Test()
        {
            ActionResult<List<WeatherObservation>> weatherStaton =
                _weatherController.GetStation("lystrup1", Convert.ToDateTime("2021-12-17"));
            Assert.AreEqual(3,weatherStaton.Value.Count);
        }

        [Test]
        public void GetStation_UserName_Date_Test_Null()
        {
            var weatherStaton =
                _weatherController.GetStation("null", Convert.ToDateTime("2021-12-17"));
            var notFoundObjectResult = new NotFoundObjectResult(weatherStaton);
            Assert.AreEqual(weatherStaton, notFoundObjectResult.Value);
        }

        [Test]
        public void GetStation_UserName_DatetoDate_Test()
        {
            ActionResult<List<WeatherObservation>> weatherStaton =
                _weatherController.GetStation("lystrup1", Convert.ToDateTime("2021-12-16"), Convert.ToDateTime("2021-12-18"));
            Assert.AreEqual(3,weatherStaton.Value.Count);
        }

        [Test]
        public void GetStation_UserName_DatetoDate_Test_Null()
        {
            ActionResult<List<WeatherObservation>> weatherStaton =
                _weatherController.GetStation("null", Convert.ToDateTime("2021-12-16"), Convert.ToDateTime("2021-12-18"));
            var notFoundObjectResult = new NotFoundObjectResult(weatherStaton);
            Assert.AreEqual(weatherStaton, notFoundObjectResult.Value);
        }
    }
}
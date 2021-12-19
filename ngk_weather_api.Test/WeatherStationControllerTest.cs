using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ngk3_weather_api.Controllers;
using ngk3_weather_api.Hubs;
using ngk3_weather_api.Models;
using ngk3_weather_api.Types;
using NSubstitute;
using NUnit.Framework;

namespace ngk_weather_api.Test
{
    [TestFixture]
    [TestFixture]
    public class WeatherStationControllerTest
    {
        private WeatherStationController _weatherStationController;
        private ApplicationDbContext _dbContext;
        private IOptions<AppSettings> _appSettings;
        private IHubContext<NotificationHub> _hubContext;
        private ClaimsPrincipal _claimsPrincipal;

        [SetUp]
        public void SetUp()
        {
            _dbContext = new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "db")
                    .EnableSensitiveDataLogging()
                    .Options);
            
            AppSettings appSettings = new AppSettings() { SecretKey = "1235467867453213456789jg"};
           _appSettings = Options.Create(appSettings);
            
            _hubContext = Substitute.For<IHubContext<NotificationHub>>();
            _claimsPrincipal = Substitute.For<ClaimsPrincipal>();
            
            _weatherStationController = new WeatherStationController(_dbContext, _appSettings, _hubContext);
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
        public void Login_Test()
        {
            var user = new Login {Password = "lystrup1Password",Username = "lystrup1"};
            var result = _weatherStationController.Login(user);
            Assert.NotNull(result.Value.Jwt);
            //Assert.AreSame(result.Value.Jwt, typeof(Token));
        }
        
        [Test]
        public void Login_Test_Failed()
        {
            var user = new Login {Password = "1234",Username = "UserXD"};
            var result = _weatherStationController.Login(user);
            Assert.NotNull(result);
            Assert.AreSame(result.GetType(), typeof(Token));
        }

        [Test]
        public void PostObservation_Test()
        {
            var addResult = new WeatherObservation
            {
                WeatherStationId = 2,
                Date = Convert.ToDateTime("2021-12-20"),
                Temperature = new decimal(34),
                Humidity = 11,
                Pressure = new decimal(1011.0)
            };
            _weatherStationController.PostObservation(addResult, "mcd1");
            var dbEntry = _dbContext.WeatherObservations;
            Assert.AreEqual(4, dbEntry.Count());;
            Assert.AreEqual(dbEntry.Last().Date,addResult.Date);
        }

        [Test]
        public void PostObservation_No_Username()
        {
            var result = _weatherStationController.PostObservation(null);
            Assert.AreEqual(new BadRequestResult().GetType(), result.GetType());
        }

        [Test]
        public void PostObservation_No_WeatherStation()
        {
            var addResult = new WeatherObservation
            {
                WeatherStationId = 10,
                Date = Convert.ToDateTime("2021-12-20"),
                Temperature = new decimal(34),
                Humidity = 11,
                Pressure = new decimal(1011.0)
            };
            var result = _weatherStationController.PostObservation(addResult, "XD");
            Assert.AreEqual(new BadRequestResult().GetType(), result.GetType());
        }
    }
}
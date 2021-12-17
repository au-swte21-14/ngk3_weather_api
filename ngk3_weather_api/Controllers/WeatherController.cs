using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ngk3_weather_api.Models;
using ngk3_weather_api.Types;

namespace ngk3_weather_api.Controllers
{
    /// <summary>
    /// API to read weather observations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : Controller
    {
        private readonly ApplicationDbContext _db;

        public WeatherController(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Get a list of all stations
        /// </summary>
        /// <returns></returns>
        [HttpGet("stations"), AllowAnonymous]
        public ActionResult<List<WeatherStation>> GetStations()
        {
            return _db.WeatherStations.ToList();
        }

        /// <summary>
        /// Get the 3 latest weather observations from a station
        /// </summary>
        /// <param name="username">Station user name</param>
        /// <returns></returns>
        [HttpGet("station/{username}"), AllowAnonymous]
        public ActionResult<List<WeatherObservation>> GetStation(string username)
        {
            var weatherStation = _db.WeatherStations.FirstOrDefault(e => e.Username == username);
            if (weatherStation == null)
            {
                return NotFound();
            }

            return _db.WeatherObservations
                .Where(e => e.WeatherStationId == weatherStation.Id)
                .OrderByDescending(e => e.Date)
                .Take(3).ToList();
        }

        /// <summary>
        /// Get all weather observations from a station at a given date
        /// </summary>
        /// <param name="username">Station user name</param>
        /// <param name="date">Date of observations</param>
        /// <returns></returns>
        [HttpGet("station/{username}/{date}"), AllowAnonymous]
        public ActionResult<List<WeatherObservation>> GetStation(string username, DateTime date)
        {
            var weatherStation = _db.WeatherStations.FirstOrDefault(e => e.Username == username);
            if (weatherStation == null)
            {
                return NotFound();
            }

            return _db.WeatherObservations
                .Where(e => e.WeatherStationId == weatherStation.Id && e.Date.Date == date.Date)
                .OrderByDescending(e => e.Date)
                .ToList();
        }
        
        /// <summary>
        /// Get all weather observations from a station at a given date
        /// </summary>
        /// <param name="username">Station user name</param>
        /// <param name="startDate">Start date of observations</param>
        /// <param name="endDate">End date of observations</param>
        /// <returns></returns>
        [HttpGet("station/{username}/{startDate}/{endDate}"), AllowAnonymous]
        public ActionResult<List<WeatherObservation>> GetStation(string username, DateTime startDate, DateTime endDate)
        {
            var weatherStation = _db.WeatherStations.FirstOrDefault(e => e.Username == username);
            if (weatherStation == null)
            {
                return NotFound();
            }

            return _db.WeatherObservations
                .Where(e => e.WeatherStationId == weatherStation.Id && e.Date.Date >= startDate.Date && e.Date.Date <= endDate.Date)
                .OrderByDescending(e => e.Date)
                .ToList();
        }
    }
}
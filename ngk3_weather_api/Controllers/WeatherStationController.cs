using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ngk3_weather_api.Models;
using ngk3_weather_api.Types;

namespace ngk3_weather_api.Controllers
{
    /// <summary>
    /// API to retrieve data from weather stations
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WeatherStationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly AppSettings _appSettings;

        public WeatherStationController(ApplicationDbContext db, IOptions<AppSettings> appSettings)
        {
            _db = db;
            _appSettings = appSettings.Value;
        }

        /// <summary>
        /// You must login before you can use any other weather station api call.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost("login"), AllowAnonymous]
        public ActionResult<Token> Login([FromBody] Login login)
        {
            if (!String.IsNullOrEmpty(login?.Username) && !String.IsNullOrEmpty(login.Password))
            {
                var weatherStation = _db.WeatherStations.FirstOrDefault(e => e.Username == login.Username);
                if (weatherStation != null && BCrypt.Net.BCrypt.Verify(login.Password, weatherStation.Password))
                {
                    return new Token {Jwt = GenerateToken(login.Username)};
                }
            }

            return BadRequest();
        }

        private string GenerateToken(string username)
        {
            var claims = new Claim[]
            {
                new(ClaimTypes.Name, username),
                new(ClaimTypes.Role, "WeatherStation"),
                new(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString())
                // Never expire, because then the station will have to login again
            };

            var payload = new JwtPayload(claims);
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appSettings.SecretKey));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(signingCredentials);
            var token = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
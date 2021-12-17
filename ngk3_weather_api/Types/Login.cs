using System.ComponentModel.DataAnnotations;

namespace ngk3_weather_api.Types
{
    public class Login
    {
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }
    }
}
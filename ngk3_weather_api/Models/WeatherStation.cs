using System.Collections.Generic;

namespace ngk3_weather_api.Models
{
    public class WeatherStation
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<WeatherObservation> WeatherObservations { get; set; }
    }
}
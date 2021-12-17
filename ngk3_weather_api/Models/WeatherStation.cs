using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ngk3_weather_api.Models
{
    public class WeatherStation
    {
        [JsonIgnore] public int Id { get; set; }
        public string Username { get; set; }
        [JsonIgnore] public string Password { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [JsonIgnore] public virtual ICollection<WeatherObservation> WeatherObservations { get; set; }
    }
}
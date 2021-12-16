using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngk3_weather_api.Models
{
    public class WeatherObservation
    {
        public int Id { get; set; }
        public int WeatherStationId { get; set; }
        public virtual WeatherStation WeatherStation { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(3,1)")] public decimal Temperature { get; set; }
        public long Humidity { get; set; }
        [Column(TypeName = "decimal(4,1)")] public decimal Pressure { get; set; }
    }
}
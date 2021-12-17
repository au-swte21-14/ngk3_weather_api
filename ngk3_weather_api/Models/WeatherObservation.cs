using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace ngk3_weather_api.Models
{
    public class WeatherObservation
    {
        [JsonIgnore] public int Id { get; set; }
        [JsonIgnore] public int WeatherStationId { get; set; }
        [JsonIgnore] public virtual WeatherStation WeatherStation { get; set; }
        [SwaggerSchema(ReadOnly = true)] public DateTime Date { get; set; }

        [Required, Column(TypeName = "decimal(3,1)")]
        public decimal Temperature { get; set; }

        [Required] public long Humidity { get; set; }

        [Required, Column(TypeName = "decimal(4,1)")]
        public decimal Pressure { get; set; }
    }
}
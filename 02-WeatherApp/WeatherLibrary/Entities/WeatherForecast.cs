using System;

namespace WeatherLibrary.Entities
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string Feeling => TemperatureC > 25 ? "🔥" : "❄";

        public string City { get; set; }
    }
}

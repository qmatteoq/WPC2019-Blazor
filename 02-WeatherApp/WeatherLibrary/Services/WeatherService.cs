using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherLibrary.Entities;

namespace WeatherLibrary
{
    public class WeatherService : IWeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast(string city)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync($"https://samplewebapi-wpc2019.azurewebsites.net/weatherforecast?city={city}");
            var results = JsonConvert.DeserializeObject<List<WeatherForecast>>(json);
            return results;
        }
    }
}

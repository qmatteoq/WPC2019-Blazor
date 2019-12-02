using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherLibrary.Entities;

namespace WeatherLibrary
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecast>> GetForecast(string city);
    }
}
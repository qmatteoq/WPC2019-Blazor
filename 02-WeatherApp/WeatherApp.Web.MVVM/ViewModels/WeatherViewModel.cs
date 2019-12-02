using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherLibrary;
using WeatherLibrary.Entities;

namespace WeatherApp.Web.MVVM.ViewModels
{
    public class WeatherViewModel
    {
        private readonly IWeatherService weatherService;

        public IEnumerable<WeatherForecast> Forecasts { get; set; }

        public string City { get; set; } = "Seattle";

        public WeatherViewModel(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public async Task GetWeatherForecast()
        {
            Forecasts = await weatherService.GetForecast(City);
        }
    }
}

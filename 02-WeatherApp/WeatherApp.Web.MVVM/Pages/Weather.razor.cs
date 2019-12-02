using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Web.MVVM.ViewModels;

namespace WeatherApp.Web.MVVM.Pages
{
    public class WeatherBase: ComponentBase
    {
        [Inject]
        WeatherViewModel WeatherViewModel { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await WeatherViewModel.GetWeatherForecast();
        }
    }
}

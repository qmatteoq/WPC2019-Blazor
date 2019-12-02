using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Web.MVVM.ViewModels;
using WeatherLibrary;

namespace WeatherApp.Web.MVVM
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IWeatherService, WeatherService>();
            services.AddSingleton<WeatherViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppBot.BusinessLogic.Services
{
    public interface IOpenWeatherApiService
    {
        Task<string> GetWeatherFromApiById(int cityId);
    }
}

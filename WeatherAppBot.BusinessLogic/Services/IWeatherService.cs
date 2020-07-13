﻿using System.Threading.Tasks;

namespace WeatherAppBot.BusinessLogic.Services
{
    public interface IWeatherService
    {
        //TODO : convert response from string to MODEL
        Task<string> GetWeather(string cityName);
    }
}

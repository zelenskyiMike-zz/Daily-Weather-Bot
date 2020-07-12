using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAppBot.Utils
{
    public static class AppConstants
    {
        public static string GetWeatherRoute => "https://api.openweathermap.org/data/2.5/weather";
        public static string ById => "?id=";
        public static string OpenWeatherAppId => "&appId=869937f0a9ca820160c75463c03eec4d";
    }
}

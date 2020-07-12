using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAppBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://localhost:8443/{0}";
        public static string Name { get; set; } = "top_weatherbot";
        public static string Key { get; set; } = "1255290436:AAFxWEsl_0NpJ9HVTgrumqX5yCkJTpkR3Wg";
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAppBot.Utils;

namespace WeatherAppBot.BusinessLogic.Services
{
    public class OpenWeatherApiService : IOpenWeatherApiService
    {
        static HttpClient client = new HttpClient();
        public async Task<string> GetWeatherFromApiById(int cityId)
        {
            string result = null;
            var path = String.Concat(AppConstants.GetWeatherRoute , AppConstants.ById , cityId , AppConstants.InMetricUnits , AppConstants.OpenWeatherAppId);

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            return result;
        }
    }
}

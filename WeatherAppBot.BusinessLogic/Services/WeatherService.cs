using System.Threading.Tasks;
using WeatherAppBot.DataAccess.Interfaces;

namespace WeatherAppBot.BusinessLogic.Services
{
    public class WeatherService : IWeatherService
    {
        ICityRepository _cityRepository;
        IOpenWeatherApiService _openWeatherService;

        public WeatherService(ICityRepository cityRepository , IOpenWeatherApiService openWeatherService)
        {
            _cityRepository = cityRepository;
            _openWeatherService = openWeatherService;
        }
        public async Task<string> GetWeather(string cityName)
        {
            var cityId = await _cityRepository.GetCityId(cityName);

            if (cityId == 0)
            {
                return "There's no city with such name. Please, ensure that you entered your city name correctly.";
            }

            var openWeatherResponse = await _openWeatherService.GetWeatherFromApiById(cityId);

            if (string.IsNullOrEmpty(openWeatherResponse))
            {
                return "There's an error while request data from server";
            }

            return openWeatherResponse;
        }
    }
}

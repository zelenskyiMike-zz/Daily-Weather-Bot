using System;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telegram.Bot;
using Telegram.Bot.Types;
using WeatherAppBot.BusinessLogic.Services;
using WeatherAppBot.DataAccess.Repositories;
using WeatherAppBot.Entities.Models;
using WeatherAppBot.Models;

namespace WeatherAppBot.BusinessLogic.Commands
{
    public class GetWeatherCommand : Command
    {
        IWeatherService _weatherService;

        public GetWeatherCommand()
        {
            _weatherService = new WeatherService(new CityRepository(new DataAccess.AppDbContext()), new OpenWeatherApiService());
        }

        public override string Name => @"/getweather";

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var cityName = "Kharkiv";

            var result = await _weatherService.GetWeather(cityName);
            var resultModel = JsonConvert.DeserializeObject< WeatherResponse >(result);

            await client.SendTextMessageAsync(chatId, $"Weather for today\nTemperature : {resultModel.Main.Temp} ºC, {resultModel.Weather.First().Description}.\nWind speed : {resultModel.Wind.Speed} m/sec", parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }

}

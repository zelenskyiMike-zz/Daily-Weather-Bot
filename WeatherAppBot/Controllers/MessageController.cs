using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using WeatherAppBot.BusinessLogic.Services;
using WeatherAppBot.Models;

namespace WeatherAppBot.Controllers
{
    [Route("api/message/update")]
    public class MessageController : Controller
    {
        IWeatherService _weatherService;
        public MessageController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome to the weather bot. Please, enter the name of the city you want to get weather.";
        }

        [HttpGet("weather")]
        public async Task<string> GetWeather([FromQuery] string cityName)
        {
            return await _weatherService.GetWeather(cityName);
        }

        [HttpPost]
        public async Task<OkResult> Post([FromBody]Update update)
        {
            if (update == null) return Ok();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }

            return Ok();
        }
    }
}
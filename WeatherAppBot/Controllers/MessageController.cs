using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Telegram.Bot.Types;
using WeatherAppBot.BusinessLogic.Services;
using WeatherAppBot.BusinessLogic;

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
        public async Task<string> Get()
        {
            //var botClient = await Bot.GetBotClientAsync();

            //var update = new Update();
            //var commands = Bot.Commands;
            //var message = update.Message;
            //foreach (var command in commands)
            //{
            //    if (command.Contains(message))
            //    {
            //        await command.Execute(message, botClient);
            //        break;
            //    }
            //}

            return "Welcome to the weather bot. Please, enter the name of the city you want to get weather.";

        }

        [HttpGet("weather")]
        public async Task<string> GetWeather([FromQuery] string cityName)
        {
            return await _weatherService.GetWeather(cityName);
        }

        //[Route(@"api/message/update")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]string update2)
        {
            var update = JsonConvert.DeserializeObject<Update>(update2);

            if (update == null) return BadRequest();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }

            return Ok();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using WeatherAppBot.BusinessLogic.Commands;
using WeatherAppBot.Models.Commands;


namespace WeatherAppBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient botClient;
        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            commandsList.Add(new GetWeatherCommand());

            //TODO: Add more commands

            botClient = new TelegramBotClient(AppSettings.Key);
            string hook = string.Format(AppSettings.Url, "api/message/update");
            await botClient.SetWebhookAsync(hook);

            return botClient;
        }
    }
}

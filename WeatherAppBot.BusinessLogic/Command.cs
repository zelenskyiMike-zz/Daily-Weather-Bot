using Telegram.Bot.Types;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WeatherAppBot.BusinessLogic
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract Task Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            return command.Contains(this.Name)/* && command.Contains(AppSettings.Name)*/;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherAppBot.BusinessLogic.Commands
{
    public class StartCommand : Command
    {
        public override string Name => @"/start";

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            await client.SendTextMessageAsync(chatId, "Hello I'm ASP.NET Core Bot", parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}

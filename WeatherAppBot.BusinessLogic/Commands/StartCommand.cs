using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherAppBot.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name => @"/start";

        //public override bool Contains(Message message)
        //{
        //    if (message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
        //        return false;

        //    return message.Text.Contains(Name);
        //}

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id /*310882370*/;
            var messageId = message.MessageId;
            await client.SendTextMessageAsync(chatId, "Hello I'm ASP.NET Core Bot", replyToMessageId : messageId,  parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}

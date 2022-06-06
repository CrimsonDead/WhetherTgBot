using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using WhetherTgBot.Handlers;

namespace WhetherTgBot.Models.Commands
{
    /// <summary>
    /// The current weather forecast command
    /// </summary>
    public class CurrentWeatherForecastCommand : Command
    {
        public override string Name => "weather now";

        public override async void Execute(Update update, ITelegramBotClient client, CancellationToken cancellationToken)
        {
            var chatId = update.Message.Chat.Id;
            var messageId = update.Message.MessageId;

            Message sentMessage = await client.SendTextMessageAsync(
                chatId: chatId,
                text: WeatherHandler.GetByCity(update.Message.Text.Substring(Name.Length + 1)),
                cancellationToken: cancellationToken);
        }
    }
}

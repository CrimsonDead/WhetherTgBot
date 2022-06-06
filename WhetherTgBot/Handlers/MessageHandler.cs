using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using WhetherTgBot.Models;

namespace WhetherTgBot.Handlers
{
    /// <summary>
    /// Request handler
    /// </summary>
    public static class MessageHandler
    {
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            //requests filter
            if (update.Type != UpdateType.Message)
                return;
            if (update.Message!.Type != MessageType.Text)
                return;

            foreach (var item in Bot.Commands)
            {
                if (item.Contains(update.Message.Text))
                {
                    item.Execute(update, botClient, cancellationToken);
                }
            }
        }
    }
}

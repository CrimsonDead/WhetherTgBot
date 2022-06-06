using Telegram.Bot;
using Telegram.Bot.Types;

namespace WhetherTgBot.Models.Commands
{
    /// <summary>
    /// Say "Hello" command
    /// </summary>
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Update update, ITelegramBotClient client, CancellationToken cancellationToken)
        {
            var chatId = update.Message.Chat.Id;
            var messageId = update.Message.MessageId;

            await client.SendTextMessageAsync(
                chatId: chatId, 
                text: "Hello!!!", 
                replyToMessageId: messageId,
                cancellationToken: cancellationToken);
        }
    }
}
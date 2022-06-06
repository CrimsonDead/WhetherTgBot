using Telegram.Bot;
using Telegram.Bot.Types;

namespace WhetherTgBot.Models.Commands
{
    /// <summary>
    /// Reply command
    /// </summary>
    public class ReplyCommand : Command
    {
        public override string Name => "reply";

        public override async void Execute(Update update, ITelegramBotClient client, CancellationToken cancellationToken)
        {
            var chatId = update.Message.Chat.Id;
            var messageText = update.Message.Text.Substring(Name.Length + 1);
            var messageId = update.Message.MessageId;

            Message sentMessage = await client.SendTextMessageAsync(
                chatId: chatId,
                text: "You said:\n" + messageText,
                cancellationToken: cancellationToken);

            Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");
        }
    }
}

using Telegram.Bot;
using Telegram.Bot.Types;

namespace WhetherTgBot.Models.Commands
{
    /// <summary>
    /// Primary command class
    /// </summary>
    public abstract class Command
    {
        public abstract string Name { get; }

        /// <summary>
        /// Performs the command execution
        /// </summary>
        /// <param name="message">Enter message</param>
        /// <param name="client">Performing client</param>
        public abstract void Execute(Update update, ITelegramBotClient client, CancellationToken cancellationToken);

        /// <summary>
        /// Checks enter command and command are equals
        /// </summary>
        /// <param name="command">It's enter command</param>
        /// <returns>Returns true if enter command contain comman name and application name</returns>
        public bool Contains(string command)
        {
            return command.Contains(this.Name); 
                //&& command.Contains(AppSettings.Name);
        }
    }
}
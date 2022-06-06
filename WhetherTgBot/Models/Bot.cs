using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using WhetherTgBot.Models.Commands;

namespace WhetherTgBot.Models
{
    /// <summary>
    /// This static class initialize bot and its commands
    /// </summary>
    public static class Bot
    {
        private static TelegramBotClient _client;
        private static List<Command> _commandsList;

        public static IReadOnlyList<Command> Commands => _commandsList.AsReadOnly();

        public static TelegramBotClient Get()
        {
            if (_client != null)
            {
                return _client;
            }

            _commandsList = new List<Command>();
            _commandsList.Add(new HelloCommand());
            _commandsList.Add(new ReplyCommand());
            _commandsList.Add(new CurrentWeatherForecastCommand());

            _client = new TelegramBotClient(AppSettings.TelegramToken);

            return _client;
        }
    }
}

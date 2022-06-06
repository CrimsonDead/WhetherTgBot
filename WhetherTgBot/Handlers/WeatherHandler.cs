using System.Net;
using System.Text.Json;
using WeatherForecast.Models;
using WhetherTgBot.Models;

namespace WhetherTgBot.Handlers
{
    /// <summary>
    /// Weather forecast handler
    /// </summary>
    public static class WeatherHandler
    {
        public static string GetByCity(string city)
        {
            string url = string.Format($"http://api.openweathermap.org/data/2.5.weather?" +
                $"q={city}&units=metric&cnt=1&" +
                $"APPID={AppSettings.OpenWeatherApiKey}");
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                RootObject weatherInfo = JsonSerializer.Deserialize<RootObject>(json);

                return $"Weather in {city}: {weatherInfo.weather[0].description}";
            }
        }

    }
}

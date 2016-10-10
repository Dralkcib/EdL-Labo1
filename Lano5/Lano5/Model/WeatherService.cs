using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lano5.Model
{
    public class WeatherService
    {
        public async Task<IEnumerable<WeatherForecast>> GetForecast()
        {
            var wc = new HttpClient();
            var weather = await wc.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/forecast?q=Namur,be&mode=json&lang=fr&appid=12d16a62ac685966c9a9b641991c6874"));
            var rawWeather = JObject.Parse(weather);
            var forecast = rawWeather["list"].Children().Select(d => new WeatherForecast()
            {
                Date = d["dt_txt"].Value<DateTime>(),
                MinTemp = d["main"]["temp_min"].Value<double>(),
                MaxTemp = d["main"]["temp_max"].Value<double>(),
                WeatherDescription = d["weather"].First["description"].Value<string>(),
                WindSpeed = d["wind"]["speed"].Value<double>()
            });
            return forecast;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://yahoo-weather5.p.rapidapi.com/weather?location=ankara&format=json&u=c"),
                Headers =
    {
        { "X-RapidAPI-Key", "e377acc97emsh8b49d7ff2f70369p1d60f2jsn2c2b95aa1ebb" },
        { "X-RapidAPI-Host", "yahoo-weather5.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                return View(values.locations.ToList());
            }
          
        }
    }
}

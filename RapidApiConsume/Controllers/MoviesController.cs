using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class MoviesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            ViewBag.t1 = "IMDB Film Listesi";
            ViewBag.t2 = "Anasayfa/Imbd";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "a63848afabmsh17767ddb31368ccp17f9adjsn3197c69e37e1" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MoviesViewModel>>(body);
                return View(values);
            }
          
        }
    }
}

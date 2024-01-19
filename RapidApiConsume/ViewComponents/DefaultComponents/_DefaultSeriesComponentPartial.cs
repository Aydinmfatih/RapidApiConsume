using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.ViewComponents.DefaultComponents
{
    public class _DefaultSeriesComponentPartial:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            ViewBag.t1 = "IMDB Dizi Listesi";
            ViewBag.t2 = "Anasayfa/Imbd";
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),
                Headers =
    {
        { "X-RapidAPI-Key", "e377acc97emsh8b49d7ff2f70369p1d60f2jsn2c2b95aa1ebb" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SeriesViewModel>>(body).Take(5).ToList();
                return View(values);
            }
        }
    }
}


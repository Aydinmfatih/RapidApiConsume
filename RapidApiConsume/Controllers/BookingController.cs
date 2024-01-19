using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.t1 = "Otel Rezervasyon İşlemi";
            ViewBag.t2 = "Anasayfa/Otel";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetFilteredHotels(string city)
        {

            var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=tr"),
    //            Headers =
    //{
    //        { "X-RapidAPI-Key", "a63848afabmsh17767ddb31368ccp17f9adjsn3197c69e37e1" },
    //          { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();

    //            var value = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
    //            TempData["destId"] = value.FirstOrDefault().dest_id;

    //        }
    //        var destId = TempData["destId"]?.ToString();

            var request1 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?order_by=popularity&checkout_date=2024-05-20&filter_by_currency=TRY&locale=tr&units=metric&dest_id=-553173&dest_type=city&adults_number=2&room_number=1&checkin_date=2024-05-19&include_adjacency=true&page_number=0&children_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0"),
                Headers =
    {
        { "X-RapidAPI-Key", "a63848afabmsh17767ddb31368ccp17f9adjsn3197c69e37e1" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request1))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BookingHotelsViewModel>>(body);
                return View(values);
            }


        }

    }

}





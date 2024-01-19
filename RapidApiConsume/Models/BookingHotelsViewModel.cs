namespace RapidApiConsume.Models
{
    public class BookingHotelsViewModel
    {
        public class Rootobject
        {
            public Result[] result { get; set; }
        }

        public class Map_Bounding_Box
        {
            public float ne_lat { get; set; }
            public float ne_long { get; set; }
            public float sw_long { get; set; }
            public float sw_lat { get; set; }
        }

        public class Room_Distribution
        {
            public string adults { get; set; }
            public int[] children { get; set; }
        }

        public class Result
        {
            public int main_photo_id { get; set; }
            public string accommodation_type_name { get; set; }
            public int class_is_estimated { get; set; }
            public int preferred { get; set; }
            public int wishlist_count { get; set; }
            public float review_score { get; set; }
            public string currency_code { get; set; }
            public int cc_required { get; set; }
            public Checkout checkout { get; set; }
            public string id { get; set; }
            public int is_free_cancellable { get; set; }
            public object is_geo_rate { get; set; }
            public string city { get; set; }
            public int is_mobile_deal { get; set; }
            public string review_score_word { get; set; }
            public int is_genius_deal { get; set; }
            public string districts { get; set; }
            public int hotel_include_breakfast { get; set; }
            public float min_total_price { get; set; }
            public string city_name_en { get; set; }
            public string zip { get; set; }
            public float mobile_discount_percentage { get; set; }
            public int cant_book { get; set; }
            public string[] block_ids { get; set; }
            public string distance_to_cc_formatted { get; set; }
            public string hotel_name { get; set; }
            public int review_nr { get; set; }
            public int is_city_center { get; set; }
            public string distance { get; set; }
            public int hotel_id { get; set; }
            public string url { get; set; }
            public string main_photo_url { get; set; }
            public string default_language { get; set; }
            public int in_best_district { get; set; }
            public int soldout { get; set; }
            public string distance_to_cc { get; set; }
            public string hotel_facilities { get; set; }
            public string country_trans { get; set; }
            public string city_in_trans { get; set; }
            public Checkin checkin { get; set; }
            public object updated_checkin { get; set; }
            public int is_beach_front { get; set; }
            public string default_wishlist_name { get; set; }
            public int accommodation_type { get; set; }
            public float longitude { get; set; }
            public string address_trans { get; set; }
            public int is_smart_deal { get; set; }
            public object selected_review_topic { get; set; }
            public string timezone { get; set; }
            public int children_not_allowed { get; set; }
            public string type { get; set; }
            public object updated_checkout { get; set; }
            public float latitude { get; set; }
            public int extended { get; set; }
            public string address { get; set; }
            public string countrycode { get; set; }
            public string district { get; set; }
            public string hotel_name_trans { get; set; }
            public int district_id { get; set; }
            public string unit_configuration_label { get; set; }
            public string max_photo_url { get; set; }
            public string max_1440_photo_url { get; set; }
            public string ribbon_text { get; set; }
            public int has_free_parking { get; set; }
        }

        public class Checkout
        {
            public string from { get; set; }
            public string until { get; set; }
        }



        public class Checkin
        {
            public string until { get; set; }
            public string from { get; set; }
        }

    



        public class Amount
        {
            public string currency { get; set; }
            public int value { get; set; }
        }

     
    


    }
}

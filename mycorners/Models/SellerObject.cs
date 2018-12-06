using System;
namespace mycorners.Models
{
    public class SellerObject
    {
        public int seller_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string store_name { get; set; }
        public string store_logo_path { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string phone_number { get; set; }
        public string cell_phone_number { get; set; }
        public string payment_method { get; set; }
        public bool order_by_app { get; set; }  //need to change it to bool in database
        public string wechat_id { get; set; }
        public string email { get; set; }
        public decimal overall_review_rating { get; set; }
        public int review_count { get; set; }

        public SellerObject()
        {
        }
    }
}

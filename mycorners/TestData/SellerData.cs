using System;
using System.Collections.Generic;
using mycorners.Models;

namespace mycorners.TestData
{
    public class SellerData
    {
        private const double V = 4.2;
        private const double V2 = 3.7;
        public List<SellerObject> sellers = new List<SellerObject>();

        public SellerData()
        {
            SellerObject seller1 = new SellerObject();
            SellerObject seller2 = new SellerObject();

            //setup seller1
            seller1.seller_id = 1;
            seller1.username = "abc@yahoo.com";
            seller1.password = "abc";
            seller1.store_name = "First Store";
            seller1.store_logo_path = "fisrt_store.jpg";
            seller1.description = "I made perfect chicken.  Free range raised chicken, organic, healthy.";
            seller1.category = "F";
            seller1.last_name = "Lee";
            seller1.first_name = "Baby";
            seller1.address = "1234 Sucess Ave";
            seller1.city = "Rockville";
            seller1.state = "MD";
            seller1.zip_code = "20850";
            seller1.cell_phone_number = "301-222-2222";
            seller1.payment_method = "Cash, paypal and credit card are allowed.";
            seller1.order_by_app = true;
            seller1.wechat_id = "djflskd";
            seller1.email = "abc@yahoo.com";
            seller1.overall_review_rating = (decimal)V;
            seller1.review_count = 20;

            sellers.Add(seller1);

            //setup seller2
            seller2.seller_id = 2;
            seller2.username = "efgh@gmail.com";
            seller2.password = "efgh";
            seller2.store_name = "Second Store";
            seller2.store_logo_path = "Second_store.jpg";
            seller2.description = "I made different crafts, including necklaces, bracelets, " +
             "soaps.  Each item can be personalized.";
            seller2.category = "A";
            seller2.last_name = "Hu";
            seller2.first_name = "Master";
            seller2.address = "5678 Cornell Ave";
            seller2.city = "Palm Spring";
            seller2.state = "CA";
            seller2.zip_code = "91111";
            seller2.cell_phone_number = "310-233-3333";
            seller2.payment_method = "Cash only.";
            seller2.order_by_app = true;
            seller2.wechat_id = "safaljfdadf";
            seller2.email = "efgh@gmail.com";
            seller2.overall_review_rating = (decimal)V2;
            seller2.review_count = 45;

            sellers.Add(seller2);

        }
    }
}

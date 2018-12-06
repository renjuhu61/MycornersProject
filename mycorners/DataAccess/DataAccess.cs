using System;
using System.Collections.Generic;
using mycorners.Models;
using mycorners.TestData;

namespace mycorners.DataAccess
{
    public class DataAccess
    {
        public DataAccess()
        {
        }

        //Get Seller object by id
        public static SellerObject GetSeller(int id)
        {
            SellerData sellerdata = new SellerData();
            List<SellerObject> sellers = sellerdata.sellers;
            SellerObject currentSeller = sellers[id - 1];

            return currentSeller; 

        }
    }
}

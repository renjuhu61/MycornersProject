using System;
using System.Collections.Generic;
using mycorners.Models;

using Xamarin.Forms;

namespace mycorners
{
    public partial class SellerHome : ContentPage
    {
        public SellerHome()
        {
            InitializeComponent();
            GetSellerInfo(1);
        }

        public void GetSellerInfo(int id)
        {

            SellerObject seller = new SellerObject();
            seller = DataAccess.DataAccess.GetSeller(1);
            String mystorename = seller.store_name;
            if (seller.store_name != null)
                lblStoreName.Text = seller.store_name; 
            if (seller.category != null)
            {
                CategoryKeyValue category = new CategoryKeyValue();
                if (category.categories.ContainsKey(seller.category))
                    lblCategory.Text = category.categories[seller.category];

            }

            if (seller.description != null)
                lblDescription.Text = seller.description;


        }
    }
}

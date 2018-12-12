using System;
using System.Collections.Generic;
using mycorners.Models;
using Xamarin.Forms;

namespace mycorners
{
    public partial class PersonalInfo : ContentPage
    {
        public PersonalInfo()
        {
            InitializeComponent();
            GetSellerInfo(1);
        }

        public void GetSellerInfo(int id)
        {

            SellerObject seller = new SellerObject();
            seller = DataAccess.DataAccess.GetSeller(1);
            String mystorename = seller.store_name;
            if (seller.email != null)
                entryEmail.Text = seller.email;
            if (seller.password != null)
                entryPwd.Text = seller.password;
            if (seller.last_name != null)
                entryLName.Text = seller.last_name;
            if (seller.first_name != null)
                entryFName.Text = seller.first_name;
            if (seller.cell_phone_number != null)
                entryPhone.Text = seller.cell_phone_number;
            if (seller.address != null)
                entryAddr.Text = seller.address;
            if (seller.city != null)
                entryCity.Text = seller.city;
            if (seller.zip_code != null)
                entryZip.Text = seller.zip_code;
            if (seller.state != null)
                entryState.Text = seller.state;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

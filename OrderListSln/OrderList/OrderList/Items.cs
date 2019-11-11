/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrderList1;
using Xamarin.Forms;
using OrderListdatabase;
namespace OrderList
{
    public class Items : Page1
    {
        public Items()
        {

            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var genderEntry = new Entry();
            genderEntry.SetBinding(Entry.TextProperty, "Gender");

            var addressButton = new Entry();
            addressButton.SetBinding(Entry.TextProperty, "Address");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var Haha = (Info)BindingContext;
                await App.Database.SaveItemAsync(Haha);
                await Navigation.PopAsync();
            };
        }
    }
}*/
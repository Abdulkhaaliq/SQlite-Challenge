using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderList1;
using OrderListdatabase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OrderList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {

        public List<Info> Orders { get; set; }

        public Page2()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var tshirts = App.Database;
            Orders = await tshirts.GetItemsAsync();
            BindingContext = this;
        }
      
     

        private  void OnDelete(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            var purchaseItem = menuItem.CommandParameter as Info;
             App.Database.DeleteItemsAsync(purchaseItem);

    
        }
 
        private async void Maping(object sender, EventArgs e)
        {
            var tshirtInfo = App.Database;
            Orders = await tshirtInfo.GetItemsAsync();
            var getAddress = string.Empty;
            foreach (var eachOrder in Orders)
            {
                getAddress = eachOrder.Address;
            }
            var geocoder = await Geocoding.GetLocationsAsync(getAddress);
            await Map.OpenAsync(geocoder.FirstOrDefault());
        }

      

    }
}
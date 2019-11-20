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
      
        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var tshirtInfo = App.Database;
            Orders = await tshirtInfo.GetItemsAsync();
            var getAddress = string.Empty;
            foreach (var eachOrder in Orders)
            {
                getAddress = eachOrder.Address;
            }
            var geocoder = await Geocoding.GetLocationsAsync(getAddress);
            await Map.OpenAsync(geocoder.First());
        }
    }
}
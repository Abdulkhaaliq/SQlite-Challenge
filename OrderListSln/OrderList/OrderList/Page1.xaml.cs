using OrderList;
using OrderListdatabase;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;

namespace OrderList1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public List<Info> tshirtInfo { get; set; }

        public Page1()
        {
            InitializeComponent();
            new NavigationPage(new MainPage());

            var purchaseItem = new Info();
            BindingContext = purchaseItem;
         
        }
       
        private async void OnSaveClicked(object sender, EventArgs e)
        {

            GetSave();
            await DisplayAlert("Purchase Successfull", "Saved (View in Orders)", "Ok");
            await Navigation.PushAsync(new MainPage());

        }

        public async void GetSave()
        {
            var purchaseItem = BindingContext as Info;
            var pathdb = App.Database;
            await pathdb.SaveItemAsync(purchaseItem);
        }

        private async void PostButton_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient(new HttpClientHandler());
            var url = "http://10.0.2.2:5000/Tshirt";

            var info = App.Database;

            tshirtInfo = await info.GetItemsAsync();


            var json = JsonConvert.SerializeObject(tshirtInfo);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                       
            try
            {
                var response = await client.PostAsync(url, content);
                await DisplayAlert("Response Message", response.ReasonPhrase, "Ok");

            }
            catch(Exception)
            {
                await DisplayAlert("Exception", "Try Again", "Ok");
            }
            
        }     
    }
}           

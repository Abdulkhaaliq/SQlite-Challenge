using OrderList;
using OrderListdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderList1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
           new NavigationPage(new MainPage());

            var purchaseItem = new Info();
            BindingContext = purchaseItem;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var purchaseItem = BindingContext as Info;
            var pathdb = App.Database;
            pathdb.SaveItemAsync(purchaseItem);

            
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }
    }
}
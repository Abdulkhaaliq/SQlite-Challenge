using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderList1;
using OrderListdatabase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
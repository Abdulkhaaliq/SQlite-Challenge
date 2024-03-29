﻿using System;
using OrderList1;
using OrderListdatabase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
      
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            ((App)App.Current).ResumeAtPersonName = -1;
          var Order = await App.Database.GetItemsAsync();

            
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1
            {
                BindingContext = new Info()
            });
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }

        private async void Orders_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}

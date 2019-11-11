using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using OrderListdatabase;
namespace OrderList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        static OrderListDatabase database;

        public static OrderListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new OrderListDatabase(
                      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OrderListSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtPersonName { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        
      
    }
}

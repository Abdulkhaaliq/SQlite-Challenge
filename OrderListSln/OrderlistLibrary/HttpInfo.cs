using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TShirtApi.Api.Models;
using static System.Net.WebRequestMethods;

namespace TShirtApiLibrary
{
    public class OrderListLibrary
    {
        public async Task<string> PostOrders()
        {
            var uri = "https://localhost:5001/Tshirt";
            var content = new StringContent("{\"name:\":\"Xamarin Shirt\"}");
            HttpClient client = new HttpClient();
            var response = await client.PostAsync(uri, content);
            return database;
        }
    }
}
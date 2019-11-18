using TShirtApi;
using System.Linq;
using TShirtApi.Api.Models;


namespace TShirtApi.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(Tshirt context)
        {
            if (!context.Informations.Any())
            {
                context.Informations.AddRange(
                    new Info
                    {
                        Name = "Alan",
                        Gender = "Male",
                        Size = "Medium",
                        Color = "White",
                        Address = "1 Sesami Street SABC Town"
                    }
                
                );

                context.SaveChanges();
            }
        }
    }
}
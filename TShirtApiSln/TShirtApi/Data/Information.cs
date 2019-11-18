using Microsoft.EntityFrameworkCore;
using TShirtApi.Api.Models;

namespace TShirtApi.Api.Data
{
    public class Tshirt : DbContext
    {
        public Tshirt(DbContextOptions<Tshirt> options)
            : base(options)
        {
        }

        public DbSet<Info> Informations { get; set; }
    }
}
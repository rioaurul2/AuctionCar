
using AuctionCar.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace AuctionCar.Repository
{
    public class AuctionCarContext : DbContext
    {
        public AuctionCarContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Buyer>? Buyers { get; set; }
    }
}

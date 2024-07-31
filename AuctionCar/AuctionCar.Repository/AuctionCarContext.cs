
using AuctionCar.Models.Auction;
using AuctionCar.Models.Users;
using AuctionCar.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AuctionCar.Repository
{
    public class AuctionCarContext : DbContext
    {
        public AuctionCarContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuctionStatusConfiguration());
        }

        DbSet<Buyer>? Buyers { get; set; }
        DbSet<Auction>? Auctions { get; set;}
        DbSet<AuctionStatus>? AuctionStatuses { get; set; }
    }
}

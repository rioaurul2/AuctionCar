
using AuctionCar.Models.Auction;
using AuctionCar.Models.Lot;
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
            ApplyConfigurations(modelBuilder);
        }

        DbSet<Buyer>? Buyers { get; set; }
        DbSet<Auction>? Auctions { get; set;}
        DbSet<AuctionStatus>? AuctionStatuses { get; set; }
        DbSet<Lot>? Lots { get; set; }
        DbSet<LotStatus>? LotStatuses { get; set; }

        private void ApplyConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuctionStatusConfiguration());
            modelBuilder.ApplyConfiguration(new LotStatusConfiguration());
        }
    }
}

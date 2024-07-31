
using AuctionCar.Models.Auction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionCar.Repository.Configurations
{
    public class AuctionStatusConfiguration : IEntityTypeConfiguration<AuctionStatus>
    {
        public void Configure(EntityTypeBuilder<AuctionStatus> builder)
        {
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new AuctionStatus
                {
                    Id = 1,
                    Status = "Active"
                },
                new AuctionStatus
                {
                    Id = 2,
                    Status = "Inactive"
                },
                new AuctionStatus
                {
                    Id = 3,
                    Status = "Suspended"
                }, 
                new AuctionStatus
                {
                    Id = 4,
                    Status = "Closed"
                }, 
                new AuctionStatus
                {
                    Id = 5,
                    Status = "Removed"
                }
            );
        }
    }
}

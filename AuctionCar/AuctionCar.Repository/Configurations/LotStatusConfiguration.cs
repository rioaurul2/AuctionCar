
using AuctionCar.Models.Lot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionCar.Repository.Configurations
{
    public class LotStatusConfiguration : IEntityTypeConfiguration<LotStatus>
    {
        public void Configure(EntityTypeBuilder<LotStatus> builder)
        {
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new LotStatus
                {
                    Id = 1,
                    Status= "Active"
                }, 
                new LotStatus
                {
                    Id = 2,
                    Status = "Closed"
                }, 
                new LotStatus
                {
                    Id = 3,
                    Status = "Upcoming"
                }, 
                new LotStatus
                {
                    Id = 4,
                    Status = "Removed"
                }, 
                new LotStatus
                {
                    Id = 5,
                    Status = "PendingApproval"
                }
            );
        }
    }
}

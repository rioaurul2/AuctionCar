using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AuctionCar.Models.Auction;
namespace AuctionCar.Models.Lot
{
    public class Lot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime OriginalDate { get; set; }

        public LotStatus? Status { get; set; }

        public Vehicle Vehicle { get; set; }

        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public Auction.Auction? Auction { get; set; }

        public IEnumerable<Bid.Bid>? Bids { get; set; }
    }
}

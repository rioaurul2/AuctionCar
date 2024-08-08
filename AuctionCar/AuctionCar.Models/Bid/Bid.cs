
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AuctionCar.Models.Users;

namespace AuctionCar.Models.Bid
{
    public class Bid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Double Price { get; set; }

        public int LotId { get; set; }

        [ForeignKey("LotId")]
        public Lot.Lot Lot { get; set; }

        public Guid BuyerId { get; set; }

        [ForeignKey("BuyerId")]
        public Buyer Buyer { get; set; }

        public DateTime DateTime { get; set; }
    }
}
 //
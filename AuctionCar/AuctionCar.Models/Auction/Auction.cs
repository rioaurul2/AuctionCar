using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionCar.Models.Auction
{
    public class Auction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Description { get; set; }

        public AuctionStatus? Status { get; set; }

        public bool IsHandled;

        public ICollection<Lot.Lot> Lots { get; set; } = new List<Lot.Lot>();

        public Auction() {
            Name = string.Empty;
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            CreatedDate = DateTime.MinValue;
            Description = string.Empty;
        }
    }
}

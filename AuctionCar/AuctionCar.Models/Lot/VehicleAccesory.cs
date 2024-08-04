
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionCar.Models.Lot
{
    public class VehicleAccesory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int VehicleDetailId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public string? Merchandise { get; set; }

        [ForeignKey("VehicleDetailId")]
        public VehicleDetails VehicleDetails { get; set; }
    }
}

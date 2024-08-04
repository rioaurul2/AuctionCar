
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionCar.Models.Lot
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string CarName { get; set; }

        public string RegistrationNumber { get; set; }

        public double Price { get; set; }

        public bool IsDamaged { get; set; } = false;

        public int VehicleDetailsId { get; set; }

        [ForeignKey("VehicleDetailsId")]
        public VehicleDetails VehicleDetails { get; set; }


    }
}

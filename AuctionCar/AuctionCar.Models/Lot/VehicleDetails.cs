using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionCar.Models.Lot
{
    public class VehicleDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Color { get; set; }

        public string Engine { get; set; }

        public int HorsePower { get; set; }

        public int NoOfDors { get; set; }

        public  IEnumerable<VehicleAccesory> VehicleAccesoryes { get; set; }
    }
}

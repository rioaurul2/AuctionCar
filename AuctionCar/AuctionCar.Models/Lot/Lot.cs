﻿using System.ComponentModel.DataAnnotations.Schema;
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

        public IEnumerable<Vehicle> Vehicles { get; set; }= new List<Vehicle>();

        public int AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public Auction.Auction? Auction { get; set; }
    }
}

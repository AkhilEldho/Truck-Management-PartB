using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class TruckRentalPb
    {
        public int RentalId { get; set; }
        public int TruckId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

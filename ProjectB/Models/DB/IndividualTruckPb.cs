using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class IndividualTruckPb
    {
        public int TruckId { get; set; }
        public string Colour { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime WofexpiryDate { get; set; }
        public DateTime RegistrationExpiryDate { get; set; }
        public DateTime DateImported { get; set; }
        public int ManufactureYear { get; set; }
        public string Status { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public decimal DailyRentalPrice { get; set; }
        public decimal AdvanceDepositRequired { get; set; }
        public int TruckModelId { get; set; }
    }
}

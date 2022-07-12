using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class TruckModelPb
    {
        public int ModelId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Size { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class TruckFeatureAssociationPb
    {
        public int TruckId { get; set; }
        public int FeatureId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class TruckPersonPb
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
    }
}

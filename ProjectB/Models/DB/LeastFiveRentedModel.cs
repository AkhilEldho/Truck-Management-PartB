using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB.Models.DB
{
    public class LeastFiveRentedModel
    {
        [Key]
        public int ModelId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Total_Sales { get; set; }
    }
}

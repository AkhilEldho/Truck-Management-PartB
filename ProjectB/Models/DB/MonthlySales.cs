using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB.Models.DB
{
    public class MonthlySales
    {
        [Key]
        public string Month { get; set; }
        public string Year { get; set; }
        public int Sales { get; set; }
        public decimal Total { get; set; }
    }
}

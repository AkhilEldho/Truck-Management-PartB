using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectB.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace ProjectB.Models
{
    internal class DAO
    {
        public static List<TopFiveRented> getTopFiveRented()
        {
            using (DAD_AkhilContext ctx = new DAD_AkhilContext())
            {
                return ctx.TopFiveRentedPbs.FromSqlRaw("getTopFiveRented").ToList();
            }
        }

        public static List<LeastFiveRentedModel> leastFiveRentedModel()
        {
            using (DAD_AkhilContext ctx = new DAD_AkhilContext())
            {
                return ctx.LeastFiveRentedModelPbs.FromSqlRaw("leastFiveRentedModel").ToList();
            }
        }

        public static List<MonthlySales> getMonthlySales(string month, string year)
        {
            using (DAD_AkhilContext ctx = new DAD_AkhilContext())
            {
                return ctx.MonthlySalesPbs.FromSqlRaw("getMonthlySales @p0, @p1", month, year).ToList();
            }
        }

        public static List<SearchModelSales> getModelSales(string model, DateTime start, DateTime end)
        {
            using (DAD_AkhilContext ctx = new DAD_AkhilContext())
            {
                return ctx.SearchModelSalesPbs.FromSqlRaw("modelSales @p0, @p1, @p2", model, start, end).ToList();
            }
        }
    }
}

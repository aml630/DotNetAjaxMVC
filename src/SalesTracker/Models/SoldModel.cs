using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{

       [Table ("Solds")]
    public class Sold
    {
        [Key]
        public int Id { get; set; }

        public string SoldName { get; set; }
        public int SoldPrice { get; set; }
        public int SoldTotal { get; set; }

        public Sold(string soldName, int soldPrice, int soldTotal, int id=0)
        {
            SoldName = soldName;
            SoldPrice = soldPrice;
            SoldTotal = soldTotal;
        }
        public Sold() { }

    }
}

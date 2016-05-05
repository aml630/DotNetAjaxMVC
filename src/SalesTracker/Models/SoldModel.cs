using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SalesTracker.Models;

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
        public int SoldCost { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Sold(string soldName, int soldPrice, int soldTotal, int soldCost, int id=0)
        {
            SoldName = soldName;
            SoldPrice = soldPrice;
            SoldTotal = soldTotal;
            SoldCost = soldCost;
        }
        public Sold() { }

    }
}

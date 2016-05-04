using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    public class Store
    {
        [Key]
        public string StoreName { get; set; }

        public int StoreRevenue { get; set; }
        
        public Store(string storeName, int storeRevenue)
        {
            StoreName = StoreName;
            StoreRevenue = storeRevenue;
        }

        public Store() { }
    }
}

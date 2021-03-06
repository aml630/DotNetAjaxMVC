﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    [Table ("Inventories")]
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public string InventoryName { get; set; }
        public int InventoryPrice { get; set; }
        public int InventoryTotal { get; set; }

        public Inventory(string inventoryName, int inventoryPrice, int inventoryTotal, int id = 0)
        {
            InventoryName = inventoryName;
            InventoryPrice = inventoryPrice;
            InventoryTotal = inventoryTotal;
        }

        public Inventory() { }
    }
}

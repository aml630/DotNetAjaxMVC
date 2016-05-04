using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SalesTracker.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesTracker.Controllers
{
    public class InventoryController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddItems(string InventoryName, int InventoryPrice, int InventoryTotal)
        {
            Inventory newInventory = new Inventory(InventoryName, InventoryPrice, InventoryTotal);
            db.Inventories.Add(newInventory);
            db.SaveChanges();
            return Json(newInventory);
        }

        public IActionResult SellItem(int inventoryId)
        {
            Console.WriteLine(inventoryId);
            var newRevenue = db.Store.FirstOrDefault();
            var targetInventory = db.Inventories.FirstOrDefault(x => x.Id == inventoryId);
           targetInventory.InventoryTotal = targetInventory.InventoryTotal - 1;
            newRevenue.StoreRevenue = newRevenue.StoreRevenue + targetInventory.InventoryPrice;
            //make new object testsolds equal to inventoryname
            var testSolds = db.Solds.FirstOrDefault(x => x.SoldName == targetInventory.InventoryName);
            if (testSolds == null){
                //if null do regular sellItem function
                Sold newSold = new Sold(targetInventory.InventoryName, targetInventory.InventoryPrice, 1);
                db.Solds.Add(newSold);
            }
            else
            {
                //if notnull add to testsold total
                testSolds.SoldTotal = testSolds.SoldTotal + 1;
            }
           


            db.SaveChanges();


            return Json(targetInventory);
        }
        
    }
}

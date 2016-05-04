using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SalesTracker.Models;

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
    }
}

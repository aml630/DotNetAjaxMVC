using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SalesTracker.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesTracker.ViewComponents
{
    public class SoldsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;
        public SoldsViewComponent(ApplicationDbContext context)
        {
            db = context;
        }

        public IViewComponentResult ServeList(int hey)
        {
            //var items = db.Solds.ToList();
            return View(hey);
        }
      
    }
}

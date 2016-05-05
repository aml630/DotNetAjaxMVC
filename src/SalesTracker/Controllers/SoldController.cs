using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SalesTracker.Models;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesTracker.Controllers
{
    public class SoldController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            // for listing child attributes from database use include lambda for object property//
            var solds = db.Solds.Include(sold => sold.Comments).ToList();

            return View(solds);
        }

        public IActionResult AddComment(string statement, int SoldId)
        {
            Comment newComment = new Comment();
            newComment.Statement = statement;
            newComment.SoldId = SoldId;
            db.Comments.Add(newComment);
            db.SaveChanges();
            return Json(newComment);
        }
    }
}

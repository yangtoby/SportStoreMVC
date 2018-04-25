using SportStore05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore05.Controllers
{
    public class ProductController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A bout for one person",
            Category = "Watersports",
            Price = 275M
        };
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.ProductCount = 0;
            return View(myProduct);
        }
    }
}
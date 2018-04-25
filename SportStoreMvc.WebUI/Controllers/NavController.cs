using SportStoreMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreMvc.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository productRepository;
        public NavController(IProductRepository repo)
        {
            productRepository = repo;
        }
        // GET: Nav
        public PartialViewResult Menu(string category=null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = productRepository.Products
                 .Select(m => m.Category)
                 .Distinct()
                 .OrderBy(m => m);
            return PartialView(categories);
        }
    }
}
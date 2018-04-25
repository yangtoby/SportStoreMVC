using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStoreMVC.Domain.Abstract;
using SportStoreMVC.Domain.Entities;
using System.Linq.Expressions;
using SportStoreMvc.WebUI.Models;

namespace SportStoreMvc.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public int PageSize = 4;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // GET: Product
        public ActionResult List(string category, int page = 1)
        {

            var model = new ProductsListViewModel
            {
                Products = productRepository.Products
                .Where(m => category == null || m.Category == category)
                .OrderBy(m => m.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    TotalItems = productRepository.Products.Where(m => category == null || m.Category == category).Count(),
                    ItemsPerPage = PageSize,
                    CurrentPage = page,
                },
                CurrentCategory = category,
            };

            return View(model);
        }

     
    }
}
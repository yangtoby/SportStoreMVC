﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStoreMVC.Domain.Abstract;
using SportStoreMVC.Domain.Entities;

namespace SportStoreMVC.Domain.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }

        public void SaveProduct(Product product)
        {
            if(product.ProductID == 0)
            {
                context.Products.Add(product);
            }else
            {
                var dbEntry = context.Products.Find(product.ProductID);
                if(dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMineType = product.ImageMineType;
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int productID)
        {
            var dbEntry = context.Products.Find(productID);
            if(dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}

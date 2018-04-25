using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore05.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
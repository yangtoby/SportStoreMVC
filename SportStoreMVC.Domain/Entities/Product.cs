﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SportStoreMVC.Domain.Entities
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMineType { get; set; }
    }
}

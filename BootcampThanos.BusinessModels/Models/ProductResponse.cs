﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.BusinessModels.Models
{
    public class ProductResponse
    {
        public string ProductCode { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string ProductLine { get; set; } = null!;
        public string ProductScale { get; set; } = null!;
        public string ProductVendor { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public short QuantityInStock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Msrp { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Qauntity must be grater or equal to {0}")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Qauntity must be grater or equal to {0}")]

        public double Price { get; set; }
        public List<ProductInventory>? ProductInventories { get; set; }

    }
}

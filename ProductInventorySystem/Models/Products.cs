using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventorySystem.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Shade { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuantity { get; set; }
    }
}

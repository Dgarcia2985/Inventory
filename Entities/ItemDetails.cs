using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ItemDetails
    {
        public int itemId { get; set; }
        public string itemCode { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public decimal purchasePrice { get; set; }
        public decimal salePrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ItemInventory
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public bool Active { get; set; }
    }
}

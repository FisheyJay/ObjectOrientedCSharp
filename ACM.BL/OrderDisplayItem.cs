using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderDisplayItem
    {
        public int OrderItemId { get; set; }

        public int OrderQuantity { get; set; }

        public string ProductName { get; set; }

        public decimal? PurchasePrice { get; set; }
    }
}

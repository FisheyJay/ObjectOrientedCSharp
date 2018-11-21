using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; private set; }
        public int ProductId { get; private set; }
        public decimal? PurchasePrice { get; private set; }

        /// <summary>
        /// Retrieves the current OrderItem
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // code that retrieves the current OrderItem
            return new OrderItem();
        }

        /// <summary>
        /// Saves the current OrderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code that saves the OrderItem
            return true;
        }

        /// <summary>
        /// Validates the OrderItem information is valid
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

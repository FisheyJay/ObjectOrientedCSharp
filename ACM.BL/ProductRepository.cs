using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // code that retrieves the current product
            Product product = new Product(productId);

            if (productId == 2)
            {
                // Temp hard-coded values to return populated customer
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes of Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save()
        {
            // code that saves the product
            return true;
        }
    }
}

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
        public OrderItem(int OrderItemId)
        {
            this.OrderItemId = OrderItemId;
        }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int OrderItemId { get;private set; }
        public decimal PurchasePrice { get; set; }
        public bool Validate()
        {
            bool isValid = true;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;
            if (!Product.Validate()) isValid = false;
            return isValid;
        }
      
    }
}

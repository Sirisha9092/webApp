using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order

    {
        public Order()
        {

         }
    public Order(int OrderId)
    {
       this.OrderId = OrderId;
    }
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public override string ToString() => $"{OrderDate.Value.Date}({OrderId})";
        public bool Validate()
        {
            bool isValid = true;
            if (!Customer.Validate) isValid = false;
            if (OrderDate==null) isValid = false;
            if (string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;

            //if (CurrentPrice <= 0) isValid = false;
            return isValid;


        }
       
    }
}
 
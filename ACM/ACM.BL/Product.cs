using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Product:EntityBase
    {
        public Product()
        {

        }
        public Product(int ProductId)
        {
            this.ProductId = ProductId;
        }
      //  public string ProductName { get; set; }
        public string Description { get; set; }
        public int ProductId { get;private set; }
        public decimal CurrentPrice { get; set; }
        public override string ToString() => ProductName;

        private string _productName; 
        public string ProductName
        {
            get
            {
              //  var stringHandler = new StringHandler();
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        //string InsetSpaces(string source)
        
        
        
        public override bool Validate()
        {
          bool isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;

            if (CurrentPrice <= 0) isValid = false;
            return isValid;


        }
       

    }
}

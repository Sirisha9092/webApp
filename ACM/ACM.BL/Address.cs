using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class Address
    {
        public string StreetLine1 { get; set; }
        public string StreetLine2{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string country { get; set; }
        public string AddressType { get; set; }
        public bool Validate()
        {
            bool isValid = true;
            if (PostalCode <= 0) isValid = false;
            return isValid;

        }
    }
}

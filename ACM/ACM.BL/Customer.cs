using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;

        }
       // public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }

        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";

                    }
                    fullName += FirstName;
                }
                return fullName;
                // return  LastName + ", " + FirstName;
            }
        }
        public override string ToString() => FullName;

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        private string _lastName;
        //public bool Validate();

        public string LastName
        {
            get
            {
                return _lastName;

            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }
        
    }
}

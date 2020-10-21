using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()

        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameTestEmpty()

        {
            Customer customer = new Customer
            {

                LastName = "Baggins"
            };
            string expected = "Baggins";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()

        {
            Customer customer = new Customer
            {

                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }

        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Siri";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.LastName = "manchala";
            Customer.InstanceCount += 1;
            Assert.AreEqual(2, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()

        {
            Customer customer = new Customer
            {

                LastName = "manchala",
                EmailAddress = "siri@gmail.com"
            };
            bool expected = false;
            bool actual = customer.Validate;
            Assert.AreEqual(expected, actual);
           // Assert.AreEqual(expected, customer.Validate);
        }
        [TestMethod]
        public void ValidateMissingLastName()

        {
            Customer customer = new Customer
            {

        
                EmailAddress = "siri@gmail.com"
            };
            bool expected = false;
            bool actual = customer.Validate;
            Assert.AreEqual(expected, actual);
            //Assert.AreEqual(expected, customer.Validate);
        }

    }
}

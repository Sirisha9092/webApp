using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTEST
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()

        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "SunF",
            Description = "Assorted size",
            CurrentPrice = 12.46M
        };
            var actual = productRepository.Retrieve(2);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
        }
  

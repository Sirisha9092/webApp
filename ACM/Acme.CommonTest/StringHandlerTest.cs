using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()

        {
            var source = "SonicScrew";
            var expected = "Sonic Screw";
           // var handler = new StringHandler();
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestExistingSpace()

        {
            var source = "Sonic Screw";
            var expected = "Sonic Screw";
           // var handler = new StringHandler();
            var actual = source.InsertSpaces();
            Assert.AreEqual(expected, actual);
        }

    }
}

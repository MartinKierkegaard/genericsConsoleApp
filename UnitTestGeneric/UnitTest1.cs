using System;
using System.Collections.Generic;
using genericsConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGeneric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCalculateInStockInt()
        {

            // Arrange: Create an instance to test:
            var iList = new List<IntItem>();
            iList.Add(new IntItem() { Itemname = "ItemInt1", Price = 100, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt2", Price = 200, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt3", Price = 500, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt4", Price = 1000, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt5", Price = 1200, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt6", Price = 70, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt7", Price = 86, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt8", Price = 2, InStock = 200 });

            // Act: Run the method under test:
            decimal resultDecimalInStockInt = Helper.CalculateInstockInt(iList);

            // Assert: Verify the result:
            Assert.AreEqual(new decimal(1600), resultDecimalInStockInt);
        }
    }
}

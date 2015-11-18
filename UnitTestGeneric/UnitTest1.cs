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
        public void TestMethodCalculateGenericDecimalItem2()
        {
            var d2List = new List<DecimalItem2>();
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal1", Price = new decimal(33.6), InStock = new decimal(120.33) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal2", Price = new decimal(23.436), InStock = new decimal(130.33) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal3", Price = new decimal(32.678), InStock = new decimal(2120.61) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal4", Price = new decimal(11.316), InStock = new decimal(6120.333) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal5", Price = new decimal(67.116), InStock = new decimal(9120.33) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal6", Price = new decimal(12.6), InStock = new decimal(510.12) });

            decimal resultDecimal2 = Helper.CalculateGenericDecimal<DecimalItem2>(d2List);

            Assert.AreEqual(new decimal(764200.063968), resultDecimal2);


        }

        [TestMethod]
        public void TestMethodCalculateGenericDecimal()
        {
            // Arrange: Create an instance to test:
            var dList = new List<DecimalItem>();
            dList.Add(new DecimalItem() { Itemname = "itemDecimal1", Price = new decimal(33.6), InStock = 120 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal2", Price = new decimal(23.436), InStock = 30 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal3", Price = new decimal(32.678), InStock = 57 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal4", Price = new decimal(11.316), InStock = 22 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal5", Price = new decimal(67.116), InStock = 77 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal6", Price = new decimal(12.6), InStock = 1000 });

            // Act: Run the method under test:

            decimal resultDecimal = Helper.CalculateGenericDecimal<DecimalItem>(dList);

            // Assert: Verify the result:
            Assert.AreEqual(new decimal(24614.610), resultDecimal);



        }


        //[TestMethod]
        //public void TestMethodCalculateSumDecimalItem2()
        //{
        //    var d2List = new List<DecimalItem2>();
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal1", Price = new decimal(33.6), InStock = new decimal(120.33) });
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal2", Price = new decimal(23.436), InStock = new decimal(130.33) });
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal3", Price = new decimal(32.678), InStock = new decimal(2120.61) });
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal4", Price = new decimal(11.316), InStock = new decimal(6120.333) });
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal5", Price = new decimal(67.116), InStock = new decimal(9120.33) });
        //    d2List.Add(new DecimalItem2() { Itemname = "item2Decimal6", Price = new decimal(12.6), InStock = new decimal(510.12) });

        //    decimal resultDecimal2 = Helper.CalculateSumDecimal2(d2List);

        //    Assert.AreEqual(new decimal(764200.063968), resultDecimal2);

        //}

        //[TestMethod]
        //public void TestMethodCalculateSumDecimalItem()
        //{
        //    var dList = new List<DecimalItem>();
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal1", Price = new decimal(33.6), InStock = 120 });
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal2", Price = new decimal(23.436), InStock = 30 });
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal3", Price = new decimal(32.678), InStock = 57 });
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal4", Price = new decimal(11.316), InStock = 22 });
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal5", Price = new decimal(67.116), InStock = 77 });
        //    dList.Add(new DecimalItem() { Itemname = "itemDecimal6", Price = new decimal(12.6), InStock = 1000 });

        //    decimal resultDecimal = Helper.CalculateSumDecimal(dList);

        //    Assert.AreEqual(new decimal(24614.610),resultDecimal);

        //}


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

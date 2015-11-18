using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace genericsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var dList = new List<DecimalItem>();
            dList.Add(new DecimalItem() { Itemname = "itemDecimal1", Price = new decimal(33.6), InStock = 120 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal2", Price = new decimal(23.436), InStock = 30 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal3", Price = new decimal(32.678), InStock = 57 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal4", Price = new decimal(11.316), InStock = 22 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal5", Price = new decimal(67.116), InStock = 77 });
            dList.Add(new DecimalItem() { Itemname = "itemDecimal6", Price = new decimal(12.6), InStock = 1000 });


            var d2List = new List<DecimalItem2>();
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal1", Price = new decimal(33.6), InStock = new decimal(120.33)});
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal2", Price = new decimal(23.436), InStock = new decimal(130.33) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal3", Price = new decimal(32.678), InStock = new decimal(2120.61) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal4", Price = new decimal(11.316), InStock = new decimal(6120.333) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal5", Price = new decimal(67.116), InStock = new decimal(9120.33) });
            d2List.Add(new DecimalItem2() { Itemname = "item2Decimal6", Price = new decimal(12.6), InStock = new decimal(510.12) });


            var iList = new List<IntItem>();
            iList.Add(new IntItem() { Itemname = "ItemInt1", Price = 100, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt2", Price = 200, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt3", Price = 500, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt4", Price = 1000, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt5", Price = 1200, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt6", Price = 70, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt7", Price = 86, InStock = 200 });
            iList.Add(new IntItem() { Itemname = "ItemInt8", Price = 2, InStock = 200 });

            decimal resultDecimal = Helper.CalculateSumDecimal(dList);
            Console.WriteLine("result sum decimal dlist : " + resultDecimal);

            decimal resultDecimal2 = Helper.CalculateSumDecimal2(d2List);
            Console.WriteLine("result sum decimal d2list: " + resultDecimal2);

            //use the generic calculate method
            decimal resultDecimalGeneric = Helper.CalculateGenericDecimal<DecimalItem>(dList);
            Console.WriteLine("generic sum DecimalItem : "+ resultDecimalGeneric);

            //use the generic calculate method
            decimal resultDecimalGenericItem2 = Helper.CalculateGenericDecimal<DecimalItem2>(d2List);
            Console.WriteLine("generic sum DecimalItem2 : " + resultDecimalGenericItem2);


            //int resultInt = Helper.CalculateSumInt(iList);
            //Console.WriteLine("result sum int : " + resultInt);

            //int resultIntInStock = Helper.CalculateInstockDecimal(dList);
            //Console.WriteLine("Result sum InStock iList : " + resultIntInStock);

            //decimal resultDecimalInStock = Helper.CalculateInstockDecimal2(d2List); 
            //Console.WriteLine("result sum InStock d2list : " + resultDecimalInStock);

            //decimal resultDecimalInStockInt = Helper.CalculateInstockInt(iList);
            //Console.WriteLine("result sum InStock ilist : " + resultDecimalInStockInt);

            Console.ReadLine();
        }
    }
}

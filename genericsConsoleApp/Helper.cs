using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace genericsConsoleApp
{
    public static class Helper
    {

        public static decimal CalculateGenericDecimal<T>(List<T> list)
            where T: ICalculateGeneric<decimal>
        {
            decimal sum = 0;
            foreach (var item in list)
            {
                sum += item.CalculateTotal();
            }

            return sum;
        }

        public static int CalculateSumInt(List<IntItem> list)
        {
            int sum = 0;
            foreach (var l in list)
            {
                sum += (l.Price * l.InStock);
            }

            return sum ;
        }



        //public static decimal CalculateSumDecimal(List<DecimalItem> list)
        //{
        //    decimal sum = 0;
        //    foreach (var l in list)
        //    {
        //        sum += l.CalculateTotal(); //(l.Price * l.InStock);
        //    }

        //    return sum;
        //}

        //public static decimal CalculateSumDecimal2(List<DecimalItem2> list)
        //{
        //    decimal sum = 0;
        //    foreach (var l in list)
        //    {
        //        sum += l.CalculateTotal();// (l.Price * l.InStock);
        //    }

        //    return sum;
        //}




        public static int CalculateInstockInt(List<IntItem> list)
        {
            int sum = 0;
            foreach (var intItem in list)
            {
                sum += intItem.InStock;
            }

            return sum;
        }

        public static int CalculateInstockDecimal(List<DecimalItem> list)
        {
            int sum = 0;
            foreach (var i in list)
            {
                sum += i.InStock;
            }

            return sum;
        }

        public static decimal CalculateInstockDecimal2(List<DecimalItem2> list)
        {
            decimal sum = 0;
            foreach (var i in list)
            {
                sum += i.InStock;
            }

            return sum;
        }


    }
}

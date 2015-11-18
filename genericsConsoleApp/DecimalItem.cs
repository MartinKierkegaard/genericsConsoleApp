using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsConsoleApp
{
    public interface ICalculateDecimal
    {
        decimal CalculateTotal();
    }

    public interface ICalculateGeneric<T>
    {
        T CalculateTotal();
    }
    

    public class DecimalItem : ICalculateGeneric<decimal> //: ICalculateDecimalGeneric
    {
        public decimal Price { get; set; }
        public string Itemname { get; set; }
        public int  InStock { get; set; }

        public decimal CalculateTotal()
        {
            return this.Price*this.InStock;
        }
    }

    public class DecimalItem2 : ICalculateGeneric<decimal>//: ICalculateDecimalGeneric
    {
        public decimal Price { get; set; }
        public string Itemname { get; set; }
        public decimal InStock { get; set; }

        public decimal CalculateTotal()
        {
            return this.Price * this.InStock;
        }

    }

    public class IntItem : ICalculateGeneric<int>
    {
        public int Price { get; set; }
        public string Itemname { get; set; }
        public int InStock { get; set; }

        public int CalculateTotal()
        {
            return this.Price * this.InStock;
        }


    }

}

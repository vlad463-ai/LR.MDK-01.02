using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class SellsAnalyzes // кол-во товаров средняя цена которых не превышает Х
    {
        public (int,double) countProducts(List <Product> Product)
        {
            List<Product> goods = new List<Product>();
            int x = 600;
            int Count = 0;
            double averagePrice = 0;
            foreach (var m in Product)
            {
                if (x> m.Price)
                {
                    goods.Add(m);
                    Count++;
                }
            }
            foreach(var m in goods)
            {
                averagePrice += m.Price;
            }
            return (Count,averagePrice);


        }
        
    }
}

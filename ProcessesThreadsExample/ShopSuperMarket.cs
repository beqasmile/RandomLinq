using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessesThreadsExample
{
    public class ShopSuperMarket
    {
        private int shopNum;
        public static int counter;

        public ShopSuperMarket(int shopNum)
        {
            this.shopNum = shopNum;
            
        }

        public void ServeVisitor()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine($"Serving visitor {this.shopNum} total num is > {ShopSuperMarket.counter}" );
                ShopSuperMarket.counter++;
                
                //Thread.Sleep(200);

            }

            Console.WriteLine($"Visitor {this.shopNum} is finished!!!");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessesThreadsExample
{
    public class ComplexThread 
    {
        private int num;

        public ComplexThread(int num)
        {
            this.num = num;
        }

        public void PrintWork()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine($"Printing from the thread number {this.num}");
                Thread.Sleep(20);
                //Thread.Sleep(200);

            }

            Console.WriteLine($"Thread {this.num} is finished!!!");
        }
    }
}

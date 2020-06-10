using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProcessesThreadsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("http://www.google.com?q=process");
            //Process.Start("C:\\dev\\18dev\\RandomLinq\\LinqExample\\bin\\Debug\\LinqExample.exe");

            //ComplexThread complexThread = new ComplexThread(1);

          
           

            //ThreadStart threadCompelxStart = new ThreadStart(complexThread.PrintWork);

            //Thread thread = new Thread(threadCompelxStart);

            //ComplexThread complexThread2 = new ComplexThread(2);

            //ThreadStart threadCompelxStart2 = new ThreadStart(complexThread2.PrintWork);

            //Thread thread2 = new Thread(threadCompelxStart2);

            //Thread thread3 = new Thread(new ThreadStart(new ComplexThread(3).PrintWork));
            //Thread thread4 = new Thread(new ThreadStart(new ComplexThread(4).PrintWork));
            //Thread thread5 = new Thread(new ThreadStart(new ComplexThread(5).PrintWork));


            //List<Thread> allThreads = new List<Thread>();
            //allThreads.Add(thread);
            //allThreads.Add(thread2);
            //allThreads.Add(thread3);
            //allThreads.Add(thread4);
            //allThreads.Add(thread5);
            


            //for (int i = 7; i < 10; i++)
            //{
            //    allThreads.Add(new Thread(new ThreadStart(new ComplexThread(i).PrintWork)));
            //}



            //foreach (var myThread in allThreads)
            //{
            //    myThread.Start();
            //}

           

            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine("Main thread is worked");
            //    Thread.Sleep(20);
            //}

            //foreach (var myThread in allThreads)
            //{
            //    myThread.Join();
            //}



            List<Thread> allThreadsShops = new List<Thread>();

            for (int i = 0; i < 15; i++)
            {
                allThreadsShops.Add(new Thread(new ThreadStart(new ShopSuperMarket(i).ServeVisitor))) ;
            }
            foreach (var myThreadShop in allThreadsShops)
            {
                myThreadShop.Start();
            }

            foreach (var myThreadShop in allThreadsShops)
            {
                myThreadShop.Join();
            }



            Console.WriteLine($"All shops are finished!!! total customers are {ShopSuperMarket.counter}");

            Console.ReadKey();
        }
    }
}

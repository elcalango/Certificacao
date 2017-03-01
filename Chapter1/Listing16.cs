using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-6 Using ThreadLocal<T>
    public static class Listing16
    {

        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
                //return 3;
            });

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine("Thread A: {0}", x);

        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < _field.Value; x++)
        //        {
        //            Console.WriteLine("Thread B: {0}", x);

        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}

    }
}

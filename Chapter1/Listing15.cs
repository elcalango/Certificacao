using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-5 Using the ThreadStaticAttribute
    public static class Listing15
    {
        
        public static int _field; 

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", _field);
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int x = 0; x < 10; x++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread B: {0}", _field);
        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-4 Stopping a thread
    public static class Listing14
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        //public static void Main()
        //{
        //    bool stopped = false;
        //    Thread t = new Thread(new ThreadStart(() =>
        //        {
        //            while (!stopped)
        //            {
        //                Console.WriteLine("Running...");
        //                Thread.Sleep(0);
        //            }
        //        }));

        //    t.Start();
        //    Console.WriteLine("Press any key to exit");
        //    Console.ReadKey();
        //    stopped = true;
        //    t.Join();

        //}

    }
}

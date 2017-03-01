using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-2 Using a background thread
    public static class Listing12
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        //public static void Main()
        //{ 
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.IsBackground = false;
        //    t.Start();
             
        //}

    }
}

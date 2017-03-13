using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-30 Using a ConcurrentBag
    public static class Listing131
    {
        public static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    bag.Add(i);
                    Thread.Sleep(1000);
                }

            });

            ConsoleKeyInfo keyInfo;

            do
            {

                keyInfo = Console.ReadKey();

                Task.Run(() =>
                {
                    int taked = 20;
                    if (bag.TryTake(out taked))
                    {
                        Console.WriteLine("Taked: " + taked);
                    }
                    else
                    {
                        Console.WriteLine("Not Taked: " + taked);
                    }
                    foreach (int i in bag)
                    {
                        
                        Console.WriteLine(i);
                    }
                }).Wait();

            } while (keyInfo.Key != ConsoleKey.Escape);

            
        }


    }
}

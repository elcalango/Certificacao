﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-28 Using BlockingCollection<T>
    public static class Listing128
    {
        //public static void Main()
        //{
        //    BlockingCollection<string> col = new BlockingCollection<string>();
        //    Task read = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine(col.Take());
        //        }
        //    });
        //    Task write = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            string s = Console.ReadLine();
        //            if (string.IsNullOrWhiteSpace(s)) break;
        //            col.Add(s);
        //        }
        //    });
        //    write.Wait();

        //}


    }
}

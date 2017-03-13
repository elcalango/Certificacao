using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-23 Unordered parallel query
    public static class Listing123
    {
        

        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 10);
        //    var parallelResult = numbers.AsParallel() 
        //        .Where(i => i % 2 == 0)
        //        .ToArray();

        //    foreach (int i in parallelResult)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadKey();

        //    var numbers2 = Enumerable.Range(0, 10);
        //    var parallelResult2 = numbers2.AsParallel().AsOrdered()
        //        .Where(i => i % 2 == 0)
        //        .ToArray();

        //    foreach (int i in parallelResult2)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadKey();

        //    var numbers3 = Enumerable.Range(0, 10);
        //    var parallelResult3 = numbers3.AsParallel().AsOrdered()
        //        .Where(i => i % 2 == 0)
        //        .AsSequential();

        //    foreach (int i in parallelResult3)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    Console.ReadKey();

        //}

        
    }
}

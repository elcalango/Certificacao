using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-27 Catching AggregateException
    public static class Listing127
    { 
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 20);

        //    try
        //    {
        //        var parallelResult = numbers.AsParallel()
        //            .Where(i => IsEven(i));

        //        parallelResult.ForAll(e => Console.WriteLine(e));
        //    }
        //    catch (AggregateException ee)
        //    {
        //        Console.WriteLine("There where {0} exceptions", ee.InnerExceptions.Count);
        //    }

        //    Console.ReadKey();

        //}

        private static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");

            return i % 2 == 0;
        }
    }
}

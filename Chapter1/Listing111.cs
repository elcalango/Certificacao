using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-10 Adding a continuation
    public static class Listing111
    {

        private static int _i = 1;
        //public static void Main()
        //{
        //    Task<int> t = Task.Run(() =>
        //    {
     
        //            return 42;
        //    });
            
        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Canceled");
        //    }, TaskContinuationOptions.OnlyOnCanceled);

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Faulted");
        //    }, TaskContinuationOptions.OnlyOnFaulted);

        //    var completedTask = t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Completed");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait();
        //    Console.ReadKey();

        //}

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-13 Using a TaskFactory
    public static class Listing113
    { 
        //public static void Main()
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var results = new Int32[3];

        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
        //            TaskContinuationOptions.ExecuteSynchronously);

        //        tf.StartNew(() => results[0] = 0);
        //        tf.StartNew(() => results[1] = 1);
        //        tf.StartNew(() => results[2] = 2);

        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith(
        //        parentTask =>
        //        {
        //            foreach (int i in parentTask.Result)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //        );

        //    finalTask.Wait();

        //}

    }
}

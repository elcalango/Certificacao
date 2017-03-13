using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-20 Using ConfigureAwait
    public static class Listing120
    {
        public static string Output { get; private set; }

        //public static void Main()
        //{
        //    Button_Click();
        //    string result = Output;
        //    Console.WriteLine(result);

        //}

        private static async  void Button_Click( )
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient
            .GetStringAsync("http://www.microsoft.com")
            .ConfigureAwait(false);
            Output = content;
        }
    }
}

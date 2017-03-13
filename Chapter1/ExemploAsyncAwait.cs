using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    //LISTING 1-20 Using ConfigureAwait
    public static class ExemploAsyncAwait
    {
        //public static char keyInput { get; private set; }

        //public static void Main()
        //{
                  

        //    int numberInput = 0;
        //    ConsoleKeyInfo userInput;
        //    montaMenu();

        //    do
        //    { 
        //        userInput = Console.ReadKey(true);

        //        // Ignore if Alt or Ctrl is pressed.
        //        if ((userInput.Modifiers & ConsoleModifiers.Alt) == ConsoleModifiers.Alt)
        //            continue;
        //        if ((userInput.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
        //            continue;
        //        // Ignore if KeyChar value is \u0000.
        //        if (userInput.KeyChar == '\u0000') continue;
        //        // Ignore tab key.
        //        if (userInput.Key == ConsoleKey.Tab) continue;


        //        if (char.IsDigit(userInput.KeyChar))
        //        {
        //            numberInput = int.Parse(userInput.KeyChar.ToString());
                    
        //        }
        //        else
        //        {
        //            numberInput = -1;
        //            Console.WriteLine("Informe o número do menu desejado!");
        //            continue;
        //        }

        //        switch (numberInput)
        //        {
        //            case 1:
        //                Console.WriteLine("Menu 1");
        //                CarregaArqUrl("http://www.microsoft.com", "c:\\microsoft.html");
        //                break;
        //            case 2:
        //                Console.WriteLine("Menu 2");
        //                CarregaArqUrl("http://www.uol.com.br", "c:\\uol.html");
        //                break;
        //            case 3:
        //                Console.WriteLine("Menu 3");
        //                CarregaArqUrl("http://www.globo.com", "c:\\globo.html");
        //                break;
        //            case 4:
        //                Console.WriteLine("Menu 4"); 
        //                break;
        //            default:
        //                Console.WriteLine("Menu não existe!");
        //                break;
        //        }

        //    } while (userInput.Key != ConsoleKey.Escape);
        //}

        private static async void CarregaArqUrl(string url, string path)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync(url).ConfigureAwait(false);

            using (FileStream sourceStream = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                .ConfigureAwait(false);
            };
        }

        
         

        private static void montaMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Menu 1");
            Console.WriteLine("2 - Menu 2");
            Console.WriteLine("3 - Menu 3");
            Console.WriteLine("ESC Para sair");

        }

    }
}

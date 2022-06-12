using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chance_V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classes
            Functions functions = new Functions();

            

            // Main
            functions.AskUser();

            functions.GeneratingWait();

            functions.Chance();

            Thread.Sleep(750);

            functions.Result();

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to close . . .");
            Console.ReadLine();

        }
    }
}

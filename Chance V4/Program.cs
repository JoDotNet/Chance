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
            MainMenu mainMenu = new MainMenu();

            mainMenu.Menu();

            Thread.Sleep(2500);

            functions.AskUser();
            functions.GeneratingWait();
            functions.Chance();

            Thread.Sleep(750);

            functions.Result();

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to close . . .");
            Console.ReadLine();




            /*
             * ADD: Main Menu
             * ADD: Percentage Calculator
             * ADD: Probability Calculator P(x, x) = 1/6 * 13/52 = 13/312 = 0.24 = 24%
             */


            /*
            // Main
            functions.AskUser();

            functions.GeneratingWait();

            functions.Chance();

            Thread.Sleep(750);

            functions.Result();

            Console.WriteLine("");
            Console.WriteLine("Press ENTER to close . . .");
            Console.ReadLine();
            */

        }
    }
}

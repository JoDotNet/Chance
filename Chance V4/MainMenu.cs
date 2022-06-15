using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chance_V4
{
    internal class MainMenu
    {
        public int choice = 0;

        public void LineCreation()
        {
            int current = 0;

            while (current <= 58)
            {
                Thread.Sleep(5);

                Console.Write("-");
                current = current + 1;
            }
        }

        public void Menu()
        {
            Console.Clear();
            Thread.Sleep(250);

            string lineWrite = @"
  _____  _                               __      __ _  _   
 / ____|| |                              \ \    / /| || |  
| |     | |__    __ _  _ __    ___  ___   \ \  / / | || |_ 
| |     | '_ \  / _` || '_ \  / __|/ _ \   \ \/ /  |__   _|
| |____ | | | || (_| || | | || (__|  __/    \  /      | |  
 \_____||_| |_| \__,_||_| |_| \___|\___|     \/       |_|  
                                                           
                                                           
";

            Thread.Sleep(500);
            Console.WriteLine(lineWrite);

            Thread.Sleep(500);
            Console.WriteLine("Credits:");

            Console.WriteLine("");

            Thread.Sleep(500);

            Console.WriteLine("Jo");
            Thread.Sleep(250);
            Console.WriteLine("https://github.com/JoDotNet");

            LineCreation();

            Thread.Sleep(500);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");



            Console.WriteLine("Options:");
            Console.WriteLine("");


            Console.WriteLine("1: Hits // Randomized Probability");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("What option do you desire?: ");
            choice = Convert.ToInt32(Console.Read());

            Options();
        }

        public void Options()
        {
            Functions func = new Functions();
            Program program = new Program();

            if (choice == 1)
            {
                program.Choice1();
            }
            else
            {
                choice = 0;

                Console.Clear();

                // add an retrying animation... + errorcode.

                Menu();
            }
        }
    }
}

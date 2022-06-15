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
                Thread.Sleep(1);

                Console.Write("-");
                current = current + 1;
            }
        }

        public void Menu()
        {
            Console.Clear();

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

            Thread.Sleep(250);

            Console.WriteLine("Jo");
            Console.WriteLine("https://github.com/JoDotNet");

            LineCreation();

            Console.WriteLine("");
            Console.WriteLine("");



            //Console.WriteLine("Options:");
            Console.WriteLine("");


            Console.WriteLine("1: Average Chance");

            //Console.WriteLine("2: Probability Calculator (In Progress)");

            Console.WriteLine("3: Random Dice");
            //Console.WriteLine("4: Random Card (In Progress)");

            Console.WriteLine("5: Random Number");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("What option do you desire?: ");
            choice = Convert.ToInt32(Console.ReadLine());

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
            else if (choice == 2)
            {
                //program.Choice2();
                Menu();
            }
            else if (choice == 3)
            {
                program.Choice3();
            }
            else if (choice == 4)
            {
                program.Choice4();
            }
            else if (choice == 5)
            {
                program.Choice5();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");

                Thread.Sleep(2500);

                Console.WriteLine("Returning.");
                Thread.Sleep(250);

                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");
                Console.WriteLine("Returning..");
                Thread.Sleep(250);

                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");
                Console.WriteLine("Returning...");
                Thread.Sleep(250);

                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");
                Console.WriteLine("Returning..");
                Thread.Sleep(250);

                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");
                Console.WriteLine("Returning.");
                Thread.Sleep(250);

                Console.Clear();
                Console.WriteLine("Unexpected error occured | Code: 0x100");
                Console.WriteLine("Returning");
                Thread.Sleep(250);

                Menu();
            }
        }
    }
}

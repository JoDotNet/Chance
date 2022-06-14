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

        public void LineCreation()
        {
            int current = 0;

            while (current <= 58)
            {
                Thread.Sleep(10);

                Console.Write("-");
                current = current + 1;
            }
        }

        public void Menu()
        {
            Console.Clear();
            Thread.Sleep(1000);

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

            Console.WriteLine("By Jo");
            Thread.Sleep(250);
            Console.WriteLine("https://github.com/JoDotNet");

            LineCreation();
        }
    }
}

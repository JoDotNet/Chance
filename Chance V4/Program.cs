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


        }

        public void Choice1()
        {
            Console.WriteLine("funny");
        }
    }
}

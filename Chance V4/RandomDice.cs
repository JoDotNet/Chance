using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chance_V4
{
    internal class RandomDice
    {

        public int generatedResult;

        public void GenRandomDice()
        {
            // Generating random dice number 1-6
            // Add ASCII art Dice (https://codegolf.stackexchange.com/questions/2602/draw-dice-results-in-ascii)

            Console.Clear();
            GenDice();

            Console.WriteLine("Random Dice Roll");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("Random Dice Roll");
            Console.WriteLine("Generating.");
            Thread.Sleep(100);

            Console.Clear();
            Console.WriteLine("Random Dice Roll");
            Console.WriteLine("Generating..");
            Thread.Sleep(100);

            Console.Clear();
            Console.WriteLine("Random Dice Roll");
            Console.WriteLine("Generating...");
            Thread.Sleep(100);

            Console.Clear();
            Console.WriteLine("Random Dice Roll");
            Console.WriteLine("");

            string strGeneratedResult = generatedResult.ToString();
            Console.WriteLine("Dice rolled: " + strGeneratedResult);

            Console.WriteLine("");
            Console.WriteLine("Returning automatically. . .");
            Thread.Sleep(5000);
            
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }

        public void GenDice()
        {
            Random random = new Random();

            generatedResult = random.Next(1, 7);
        }
    }
}

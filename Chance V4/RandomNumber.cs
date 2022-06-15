using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chance_V4
{
    internal class RandomNumber
    {

        public int generatedResult;

        public void GenRandomNum()
        {
            // Generating random number between user's selected preferance.

            Console.Clear();

            Console.WriteLine("Generate a random number of your choice");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Example:");
            Console.WriteLine("");

            Console.WriteLine("Minimum Number: 1");
            Console.WriteLine("Maximum Number: 100");
            Console.WriteLine("Result: Random Number between 1 - 100");

            Console.WriteLine("");
            Console.WriteLine("");




            int minNum;
            int maxNum;


            Console.Write("Minimum Number: ");
            minNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maximum Number: ");
            maxNum = Convert.ToInt32(Console.ReadLine());

            RandomNum(minNum, maxNum);

            Console.Clear();

            string strGeneratedResult = generatedResult.ToString();
            Console.WriteLine("Number Generated: " + strGeneratedResult);

            Console.WriteLine("");

            Console.WriteLine("Returning automatically . . .");

            MainMenu mainmenu = new MainMenu();
            Thread.Sleep(5000);
            mainmenu.Menu();
        }

        public void RandomNum(int minNum, int maxNum)
        {

            Random random = new Random();

            generatedResult = random.Next(minNum, maxNum);
        }
    }
}

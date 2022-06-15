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
            //Functions functions = new Functions();
            MainMenu mainMenu = new MainMenu();


            mainMenu.Menu();


        }

        public void Choice1()
        {

            Functions functions = new Functions();
            MainMenu mainMenu = new MainMenu();

            mainMenu.choice = 0;

            Console.WriteLine("Worked here :)");

            functions.AskUser();
            functions.GeneratingWait();
            functions.Chance();

            Thread.Sleep(750);

            functions.Result();

            Thread.Sleep(5000);
            mainMenu.Menu();
        }

        public void Choice2()
        {
            // unused
        }

        public void Choice3()
        {
            // Random Dice
            RandomDice randomDice = new RandomDice();

            randomDice.GenRandomDice();
        }

        public void Choice4()
        {
            // Random Card
        }

        public void Choice5()
        {
            // Random Number
            RandomNumber randomNumber = new RandomNumber();

            randomNumber.GenRandomNum();

        }
    }
}

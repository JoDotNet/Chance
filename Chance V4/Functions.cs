using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chance_V4
{
    internal class Functions
    {

        public int percentage = 0;
        public int tries = 0; 
        
        public int current = 0;

        public int hits = 0;

        public void GenerateNumber()
        {
            Thread.Sleep(1);
            System.Random random = new System.Random();

            int randomNum = random.Next(1, 100);

            Console.WriteLine(randomNum);

            if (randomNum <= percentage)
            {
                hits = hits + 1;
            }
        }

        public void Chance()
        {
            while (current <= tries)
            {
                current = current + 1;
                GenerateNumber();
            }
        }

        
        
        public void AskUser()
        {
            // On Start
            Console.Clear();

            // String Int's
            string percentageStr = "";
            string triesStr = "";



            // Percentage
            Console.Clear();
            Console.WriteLine("Chance: ");
            percentage = Convert.ToInt32(Console.ReadLine());
            percentageStr = Convert.ToString(percentage);

            Console.Clear();
            Console.WriteLine("Chance is set to: " + percentageStr + "%");


            Thread.Sleep(1000);


            // Tries
            Console.Clear();
            Console.WriteLine("Tries: ");
            tries = Convert.ToInt32(Console.ReadLine());
            triesStr = Convert.ToString(tries);

            Console.Clear();
            Console.WriteLine("Tries is set to: " + triesStr);


            Thread.Sleep(1000);
            Console.Clear();
        }



        public void GeneratingWait()
        {
            Console.Clear();

            Console.WriteLine("Generating your results");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results.");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results..");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results...");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results..");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results.");
            Thread.Sleep(250);
            Console.Clear();

            Console.WriteLine("Generating your results");
            Thread.Sleep(250);
        }

        public void Result()
        {
            Console.Clear();

            string resultHits = hits.ToString();
            string resultTries = tries.ToString();
            string resultPercentage = percentage.ToString();

            //Console.WriteLine("Number of hits: " + resultHits + "out of " + resultTries + " tries");
            Console.WriteLine(resultHits + " hit" + " out of " + resultTries + " tries");
            Console.WriteLine("Percentage: " + resultPercentage);
        }
    }
}

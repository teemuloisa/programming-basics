using System;

namespace loop2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Console.WriteLine("Syötä heittojen lukumäärä.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int heads = 0;
            int tails = 0;
            


            for (int n = 1; n <= number; n++)
            {
                if (rnd.NextDouble() >= 0.5)               
                    heads++;             
                else
                    tails++;
                

            }
            Console.WriteLine(($" Rahaa on heitetty {number} kertaa.\n"));
            Console.Write(($" Klaavoja tuli {tails}\n"));
            Console.Write(($" Kruunuja tuli {heads}"));
            Console.ReadKey();


        }
    }
}

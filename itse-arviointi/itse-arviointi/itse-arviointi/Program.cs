using System;

namespace itse_arviointi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä teksti, jonka ohjelma tulostaa viisi kertaa.");
            string userInput = Console.ReadLine();

            for (int n = 1; n <= 4; n++)
            {
                Console.Write($"{userInput}\n");
            }
            Console.ReadKey();

        }
    }
}

using System;

namespace itse_arviointi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä teksti, jonka ohjelma tulostaa niin monta kertaa kuin tekstissä on kirjaimia. ");
            string userInput = Console.ReadLine();
            Console.Clear();

            for (int n = 1; n <= userInput.Length; n++)
            {                
                Console.Write($"{userInput}\n");
            }

          //  Console.WriteLine($"{userInput.Length}");

            Console.ReadKey();
        }
    }
}

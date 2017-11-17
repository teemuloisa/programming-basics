using System;

namespace loop2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kutoset = 0;
            Console.WriteLine("Ohjelma simuloi nopan heittoa 1000 ja näyttää lukujen 6 määrän.");
            for (int i = 1; i <= 1000; i++)
            {

                int luku = rnd.Next(6) + 1;
                Console.WriteLine($"{i}. {luku}");
                if (luku == 6)
                    kutoset++;
            }
            Console.WriteLine($"Kutosia on numeroiden joukossa {kutoset}");
            Console.ReadKey();
        }
    }
}

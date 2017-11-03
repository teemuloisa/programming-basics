using System;

namespace loop2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            for (int n = 0; n <= 11; n++)
            {
                double rndValue = rnd.NextDouble();
                Console.Write($"{n + 1}. ");
                if (rndValue <= 0.4)
                {
                    Console.Write("1\n");
                }

                else if(rndValue > 0.4 && rndValue <= 0.6)
                {
                    Console.Write("x\n");

                }

                else
                {
                    Console.Write("2\n");
                }
            }

            Console.ReadKey();

        }
    }
}

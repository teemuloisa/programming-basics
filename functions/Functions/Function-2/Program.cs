using System;

namespace Function_2
{
    class Program
    {
        static string minimi(int n, int y)
        {
            if (n > y)
            {
                Console.WriteLine($"Luku {n} on suurempi kuin luku {y}");
            }
            else
                Console.WriteLine($"Luku {y} on suurempi kuin luku {n}");

        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Functions - Task 1. \n");

            int n;
            int y;

            Console.Write("Syötä kaksi lukua: ");
            n = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            string vertailu = minimi(n,y);
            Console.WriteLine(vertailu);
            Console.ReadKey();


        }
    }
}

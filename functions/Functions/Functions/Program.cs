using System;

namespace Functions
{
    class Program
    {
        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += "*";
            }
            return res;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Functions - Task 1. \n");

            int n;
            while (true)
            {
                Console.Write("Tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"Luku {n} ei ole sallittu luku");
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
        }
    }
}

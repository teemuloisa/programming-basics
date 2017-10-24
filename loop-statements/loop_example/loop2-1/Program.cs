using System;

namespace loop2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{i}\t\t{Math.Round(Math.Sqrt(i), 2)}"); 
                
                i = i + 1;
            } while (i <= 10);

            Console.ReadKey();

        }
    }
}

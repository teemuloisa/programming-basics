using System;

namespace loop2_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            int n = 1;
            do
            {
                int i = 1;
                do
                {
                    Console.WriteLine($"{n} x {i} = {(n * i)}");
                    i = i + 1;
                } while (i <= 10);
                n = n + 1 ;
            } while (n <= 10);
            Console.ReadKey();
        }
    }
}

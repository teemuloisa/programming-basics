using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Random rnd = new Random();
          

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(40);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            int lisanumero = rnd.Next(40);
            int tuplausnumero = rnd.Next(40);
            Console.WriteLine($"Lisänumero: {lisanumero}");
            Console.WriteLine($"Tuplausnumero: {tuplausnumero} ");

            Console.ReadKey();
        }
    }
}

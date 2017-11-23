using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random rnd = new Random();
            int sum = 0;
            int average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50);
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = sum / 100;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}");
                Console.WriteLine(array[i]);
            }

         //   Console.WriteLine($"Summa: {sum}");
            Console.WriteLine($"Keskiarvo: {average}");
            Console.ReadKey();
        }
    }
}

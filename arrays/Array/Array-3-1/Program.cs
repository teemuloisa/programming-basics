using System;

namespace Array_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(20);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = {array[i]} \n");
            }

            Console.ReadKey();
        }

        static void Muunnos()
        {

        }
    }
}

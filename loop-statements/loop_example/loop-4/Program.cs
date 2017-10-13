using System;

namespace loop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee summan. Anna luku, jonka summa lasketaan.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 0;

            if (number < 0)
            {
                do
                {
                    //  Console.WriteLine(i);
                    i = i - 1;


                    f = f - -i;
                    //Console.WriteLine($"{i}!={f}");

                } while (i > number);

                Console.WriteLine($"Syötit{i}\n vastaus{f}");

                Console.ReadKey();
            }

            else
            {

                do
                {
                    //  Console.WriteLine(i);
                    i = i + 1;


                    f = f + i;
                    //Console.WriteLine($"{i}!={f}");

                } while (i < number);

                Console.WriteLine($"Syötit{i}\n vastaus{f}");

                Console.ReadKey();
            }
        }
    }
}

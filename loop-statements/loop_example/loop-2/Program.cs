using System;

namespace loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kertoma. Anna luku, jonka kertoma lasketaan.");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;

            if (number < 0)
            {
                Console.WriteLine("Määrittelemätön.");
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

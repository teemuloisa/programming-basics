using System;

namespace loop_3
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
            int f = 0;
            int x = 0;
            int y = 0;

            if (number < 0)
            {
                Console.WriteLine("Määrittelemätön.");
                Console.ReadKey();
            }

            else if (number % 2 == 0 )
            {



                do
                {
                    //  Console.WriteLine(i);
                    i = i + 1;

                    f = f + i;
                    //Console.WriteLine($"{i}!={f}");

                } while (i < number);

                do
                {
                    //  Console.WriteLine(i);
                    x = x + 1;

                    y = y + x;
                    //Console.WriteLine($"{i}!={f}");

                } while (x < number);

                Console.WriteLine($"Syötit{i}\n parillinen{f} pariton{y}");

                Console.ReadKey();

            }



        }
    }
}

using System;
using System.Collections.Generic;

namespace task_4
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isNumber;


            Console.Write("Syötä luku 1: ");
            string userInput1;
            userInput1 = Console.ReadLine();

            Console.Write("Syötä luku 2: ");
            string userInput2;
            userInput2 = Console.ReadLine();

            Console.Write("Syötä luku 3: ");
            string userInput3;
            userInput3 = Console.ReadLine();

            isNumber = int.TryParse(userInput1, out int X);

            isNumber = int.TryParse(userInput2, out int Y);

            isNumber = int.TryParse(userInput3, out int Z);


            if (X < Y)
            {
                if (X < Z)
                {
                    if (Y < Z)
                    {
                        Console.WriteLine($"{X}, {Y}, {Z}");

                    }

                    else
                    {
                        Console.WriteLine($"{X}, {Z}, {Y}");

                    }
                }

                else
                {
                    Console.WriteLine($"{Z}, {X}, {Y}");

                }

            }

            else
            {
                if (X < Z)
                {
                    Console.WriteLine($"{Y}, {X}, {Z}");

                }

                else
                {
                    if (Y<Z)
                    {
                        Console.WriteLine($"{Z}, {Y}, {X}");

                    }

                    else
                    {
                        Console.WriteLine($"{Y}, {Z}, {X}");


                    }
                }

                Console.ReadKey();

            }







        }
    }
}

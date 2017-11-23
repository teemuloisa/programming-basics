using System;

namespace Function_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Suurin luku oli " + Numerot());
            Console.ReadKey();
        }
        static int Numerot()
        {
            int num = 0;
            int max = 0;
            int maxIndex = 0;
            bool isNumber;
            string output = "";
            Console.WriteLine("Syötä 10 postiiivista lukua");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");
                isNumber = int.TryParse(Console.ReadLine(), out num);
                if (isNumber && num > 0)
                {
                    output += num;
                    if (max < num)
                    {
                        max = num;
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte,syötä positiivinen luku.");
                        i --;
                }

                output += num;
            }
            return max;
        }  
        }
    }


using System;

namespace loop_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
           


          for(int i = 0; i < 4; i++)
            {
                Console.Write($"rivi {i+1}: ");

                for(int j = 0; j<5; j++)
                {
                    int value = rnd.Next(1, 51);

                    if(j < 4)
                    {
                        Console.Write($"{value}, ");
                    }
                    else
                    {
                        Console.Write($"{value}\n");
                    }

                }
             

            }

            Console.ReadKey();
               

        }
    }
}

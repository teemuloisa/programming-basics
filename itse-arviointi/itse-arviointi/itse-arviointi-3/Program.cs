using System;

namespace itse_arviointi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Syötä lukuja. ");

            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int summa = 0;
           
            do
            {
               if(number == -1)
                {
                    break;
                }
               else
                {
             
                    summa = summa + number;
                }

                userInput = Console.ReadLine();
                number = int.Parse(userInput);
            } while (true);
            Console.Write($"Lukujen summa on {summa}. ");

            Console.ReadKey();
        }
    }
}

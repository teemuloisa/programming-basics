using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma tulostaa parillinen tai pariton.");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                
                isNumber = int.TryParse(userInput, out int evaluatedNumber);

                if (isNumber == true)
                {

                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on parillinen.");

                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on pariton.");

                    }
                    
                }

                else
                {
                    Console.WriteLine("Oletko hieman yksinkertainen? Et syöttänyt lukua.");

                }
            } while (isNumber == false);
            Console.ReadKey();
        }
    }
}

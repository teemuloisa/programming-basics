using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                string userInput;
                userInput = Console.ReadLine();

                // int evaluatedNumber;
                isNumber = int.TryParse(userInput, out int evaluatedNumber);

                if (isNumber == true)
                {

                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen.");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen.");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

                    }

                    else
                    {
                        Console.WriteLine($"Numero on 0.");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

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

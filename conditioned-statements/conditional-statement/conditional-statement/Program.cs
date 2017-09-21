using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput= Console.ReadLine();

           // int evaluatedNumber;
            int.TryParse(userInput, out int evaluatedNumber);

            if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen.");
                //  Console.WriteLine($"Syötit arvon {userInput}") ;
                Console.ReadKey();
            }
            else if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen.");
                //  Console.WriteLine($"Syötit arvon {userInput}") ;
                Console.ReadKey();
            }

            else ()
            {
                Console.WriteLine($"Numero {evaluatedNumber} on 0.");
                //  Console.WriteLine($"Syötit arvon {userInput}") ;
                Console.ReadKey();
            }
        }
    }
}

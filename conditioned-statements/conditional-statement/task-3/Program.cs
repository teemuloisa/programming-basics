using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ohjelma tulostaa onko luku positiivinen, negatiivinen tai nolla sekä onko se parillinen tai pariton.");
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
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

                        if (evaluatedNumber % 2 == 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on parillinen.");

                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on pariton.");

                        }

                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.Write($"Numero {evaluatedNumber} on positiivinen");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

                        if (evaluatedNumber % 2 == 0)
                        {
                            Console.Write(" ja parillinen.");

                        }
                        else
                        {
                            Console.Write(" ja pariton.");

                        }

                    }

                    else
                    {
                        Console.Write($"Numero on 0.");
                        //  Console.WriteLine($"Syötit arvon {userInput}") ;

                        if (evaluatedNumber % 2 == 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on parillinen.");

                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on pariton.");

                        }

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
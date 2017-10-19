using System;

namespace loop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Ohjelma laskee parillisten ja parittomien summan. Anna luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;

            int evenSum = 0; //Parilliset
            int oddSum = 0; //Parittomat

            if (number < 0)
            {
                do
                {
                    if (i % 2 == 0)
                        evenSum = evenSum - -i;
                    else
                        oddSum = oddSum - -i;
                    i = i + -1;
                } while (i >= number);
                Console.WriteLine($"Parillisten summa: {evenSum}\nParittomien summa: {oddSum}");

                Console.ReadKey();
            }

            else
            {
                do
                {
                    if (i % 2 == 0)
                        evenSum = evenSum + i;
                    else
                        oddSum = oddSum + i;
                    i = i + 1;
                } while (i <= number);
                Console.WriteLine($"Parillisten summa: {evenSum}\nParittomien summa: {oddSum}");

                Console.ReadKey();
            }
        }
    }
    }


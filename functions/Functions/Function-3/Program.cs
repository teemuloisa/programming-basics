using System;


namespace Function_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Functions - Task 3. \n");

            
    
            

            int lowerBound = 10;
            int upperBound = 20;
            

            int tulos = NumberFromRange(lowerBound, upperBound);
            Console.WriteLine(tulos);
            Console.ReadKey();
            


        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {

            while (true)
            {

                int userInput;
                Console.Write($"Syötä luku väliltä {lowerBound}-{upperBound}.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput >= lowerBound && userInput <= upperBound)
                {
                    string res = string.Empty;
                    res = ($"Syötit luvun {userInput}.");

                    return res;
                }
                else
                {
                    break;
                }
                
            }


        }
    }
}

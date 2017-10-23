using System;

namespace Function_2
{
    class Program
    {
        static string minimi(int n, int y)
        {       
            if (n > y)
            {
            
                string res = string.Empty;
                res = ($"Luku {n} on suurempi kuin luku {y}");
                return res;

            }
            else if (y > n)
            {
           
                string res = string.Empty;
                res = ($"Luku {y} on suurempi kuin luku {n}");
                return res;
            }

            else if (y == n)
            {

                string res = string.Empty;
                res = ($"Luku {y} on yhtä suuri kuin {n}");
                return res;
            }

            else
            {
             
                string res = string.Empty;
                res = ("Et syöttänyt lukua.");
                return res;
            }
            
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Functions - Task 2. \n");
            Console.WriteLine("Syötä kaksi lukua.");
            int n;
            int y;

            Console.Write("Luku 1: ");
            n = int.Parse(Console.ReadLine());



            Console.Write("Luku 2: ");
            y = int.Parse(Console.ReadLine());



            string vertailu = minimi(n, y);
            Console.WriteLine(vertailu);
            Console.ReadKey();


        }
    }
}

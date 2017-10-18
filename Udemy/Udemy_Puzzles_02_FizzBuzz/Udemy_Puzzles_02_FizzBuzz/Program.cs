using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_02_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop solution \n");

            string text;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    text = "FizzBuzz";
                else if (i % 3 == 0)
                    text = "Fizz";
                else if (i % 5 == 0)
                    text = "Buzz";
                else
                    text = i.ToString();
                Console.WriteLine(text);

                Console.WriteLine("");
                Console.WriteLine("Recursive solution");
                RecursiveSolution(100);

                Console.ReadLine();
            }



        }


        private static void RecursiveSolution(int n)
        {
            string text = "";

            if (n < 1)
                return;
            if (n % 15 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();
            Console.WriteLine(text);

            RecursiveSolution(n - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_03_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fbonacci loop solution");

            var number1 = 0;

            var number2 = 1;

            Console.WriteLine($"number1 : {number1} \n");

            Console.WriteLine($"number2 : {number2} \n");
            for (int i = 0; i <= 15; i++)
            {
                var next = number1 + number2;

                number1 = number2;

                number2 = next;

                Console.WriteLine($"Next: {next} \n");

            }
            Console.WriteLine("");
            Console.WriteLine("Fibonacci recursive solution with return value");
            Console.WriteLine(0);//修正程式第一筆答案須為0

            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(RecursiveSolution(i));
            }
        }

        private static int RecursiveSolution(int n)
        {
            if (n <= 1)
                return 1;

            return RecursiveSolution(n - 2) + RecursiveSolution(n - 1);
        }
    }
}

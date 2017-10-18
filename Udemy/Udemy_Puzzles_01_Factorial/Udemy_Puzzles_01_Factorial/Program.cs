using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_01_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth value as integer : ");

            var n = Convert.ToInt32(Console.ReadLine());
            
            
            //loop calculation
            Console.WriteLine($"Loop calculation : Factorial of {n} as {CalculateLoop(n)} \n");

            Console.WriteLine($"Loop2 calculation : Factorial of {n} as {CalculateLoop2(n)} \n");

        

            //recursion calculation
            Console.WriteLine($"CalculateRecursion : Factorial of {n} as {CalculateRecursion(n)} \n");

            Console.Read();
        }

        private static int CalculateLoop(int n)
        {
            var factorial = 1;

            for (int i = n; i >=1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateLoop2(int n )
        {
            var factorial = n;
            for (int i = 1; i < n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int CalculateRecursion (int n)
        {
            if (n == 1)
                return 1;
            return n * CalculateRecursion(n - 1);
           
        }
    }
}

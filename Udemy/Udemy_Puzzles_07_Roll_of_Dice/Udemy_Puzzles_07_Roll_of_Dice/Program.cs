using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_07_Roll_of_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            var die1 = new Die();
            var die2 = new Die();

            int[] stats = new int[13];
            int[,] rolls = new int[7, 7];

            Console.WriteLine("Please enter how many times you want to roll the dice : ");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i< n; i++)
            {
                var die1Value = die1.DieRoll();
                var die2Value = die2.DieRoll();

                rolls[die1Value, die2Value] += 1;


                var sum = die1Value + die2Value;
                stats[sum] += 1;
            }

            //display sums
            for(int i =2; i <=12; i++)
            {
                Console.WriteLine($"Sum of {i} occured {stats[i]} times. ");                
            }

            //matrix(矩陣) dispaly
            Console.WriteLine("");
            Console.WriteLine("\t1\t2\t3\t4\t5\t6");
            Console.WriteLine("\t-------------------------------------------");
            for(int r = 1; r <= 6; r++)
            {
                Console.Write(r);
                for(int c = 1; c <= 6; c++)
                {
                    Console.Write("\t" + rolls[r,c]);
                }
                Console.Write("\n");
            }
        }
    }
}

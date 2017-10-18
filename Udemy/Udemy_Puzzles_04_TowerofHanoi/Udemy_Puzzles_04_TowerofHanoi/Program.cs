using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_04_TowerofHanoi
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            var discs = 0;
            Console.WriteLine("Please enter the number of discs : ");

            discs = Convert.ToInt32(Console.ReadLine());

            Tower(discs, 1, 3, 2);
        }

        static void Tower(int n, int sourcePeg, int destinationPeg, int sparePeg)
        {
            if (n == 1)
            {
                //此處為只剩最後一個disc可移動的功能，把最後一個disc從sourcePeg 移動到 destinationPeg
                Console.WriteLine(counter + "  " + sourcePeg + " -> " + destinationPeg);
                counter++;
            }
            else
            {
                Tower(n - 1, sourcePeg, sparePeg, destinationPeg);

                Console.WriteLine(counter + "  " + sourcePeg + " -> " + destinationPeg);
                counter++;
                Tower(n - 1, sparePeg, destinationPeg, sourcePeg);
            }
        }
    }
}

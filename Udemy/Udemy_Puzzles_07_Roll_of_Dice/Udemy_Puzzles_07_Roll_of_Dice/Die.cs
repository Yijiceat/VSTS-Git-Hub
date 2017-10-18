using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Puzzles_07_Roll_of_Dice
{
    public class Die
    {
        static Random rand = new Random();
        public int DieRoll()
        {            
            return rand.Next(1, 7);//最小值包含本身(1),最大值則不包含本身(7),所以會亂數產生1-6的值
        }
    }
}

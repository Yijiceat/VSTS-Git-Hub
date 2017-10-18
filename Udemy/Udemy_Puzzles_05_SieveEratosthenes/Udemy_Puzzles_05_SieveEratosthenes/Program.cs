using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//此專案是找出指定範圍內所有的質數
//埃拉托斯特尼篩法
//參考wiki
//https://zh.wikipedia.org/zh-tw/%E5%9F%83%E6%8B%89%E6%89%98%E6%96%AF%E7%89%B9%E5%B0%BC%E7%AD%9B%E6%B3%95
namespace Udemy_Puzzles_05_SieveEratosthenes
{
    class Program
    {
        static bool[] allNumbers;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 'n' : ");

            var n = Convert.ToInt32(Console.ReadLine());

            var arrSize = n + 1;

            CreateArray(arrSize);

            Sieve(arrSize);
        }

        static void Sieve(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (allNumbers[i])//只抓陣列標記為True的資料
                {
                    //此處 i * c < n 設定是 i(質數) * c(倍數) < n (數字範圍) 只要大於n就代表該停止此迴圈
                    for (int c = i; i * c < n; c++)
                    {
                        allNumbers[i * c] = false; //這段標記質數的倍數的陣列資料為false
                    }
                }
            }

            var counter = 0;

            for(int i = 2; i <n; i ++)
            {
                if(allNumbers[i])
                {
                    Console.Write(i + "  " );
                    counter++;
                }

                if (counter == 10)
                {
                    Console.Write("\n");
                    counter = 0;
                }
            }
        }

        static void CreateArray(int n)
        {
            allNumbers = new bool[n];

            for (int i = 0; i < n; i++)
            {

                allNumbers[i] = true;
            }
        }
    }
}

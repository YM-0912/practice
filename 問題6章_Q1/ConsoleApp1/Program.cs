using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //応用問題：P181-Q1
    class Program
    {
        static void Main(string[] args)
        {
            //8個の整数
            int[] numbers = new int[8];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            numbers[5] = 60;
            numbers[6] = 70;
            numbers[7] = 80;

            //合計値
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine($"合計値は{total}です。");

            //平均値
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                average = (double)total / numbers[i];
            }

            Console.WriteLine($"平均値は{average}です。");
        }
    }
}

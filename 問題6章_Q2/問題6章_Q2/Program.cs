using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題6章_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //①要素数が20の1次元配列に100～119までの整数を順に格納する
            //②①を格納する際は必ずループ処理を使用する
            //③全ての要素をcmd.exeに出力する

            //要素数が20の一次元配列
            int[] numbers = new int[20];
            //100～119までの整数をnumbersに格納する
            int num = 99;
            for (int i = 0; i < numbers.Length; i++)
            {
                num ++;
                Console.WriteLine($"要素：{num}");
            }

        }
    }
}

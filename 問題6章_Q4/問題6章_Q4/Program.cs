using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題6章_Q4
{
    class Program
    {
        static void Main(string[] args)
        {

            //6×2の2次元配列
            //cmd.exeに以下のように表示する 2重ループは使わない
            //
            //日曜日(sun)
            //月曜日(mon)
            //火曜日(tue)
            //水曜日(wed)
            //木曜日(thu)
            //金曜日(fri)
            //土曜日(sat)

            //2次元配列の行と列の要素数を指定
            var oneWeekList = new string[,]
            {
                {"日曜日","(sun)" },
                {"月曜日","(mon)" },
                {"火曜日","(tue)" },
                {"水曜日","(wed)" },
                {"木曜日","(thu)" },
                {"金曜日","(fri)" },
                {"土曜日","(sat)" },

            };

            for (int row = 0; row < oneWeekList.GetLength(0);row++)
            {
                Console.WriteLine($"{oneWeekList[row,0]}{oneWeekList[row,1]}");
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題9章_Q1
{
    /// <summary>
    /// 問題9章：クラスを使いこなそう
    /// 　①キーボードから小数点付きの数値を2つ入力し、小さい方を表示する　Math.Minを使用すること
    /// 　②キーボードから入力した小数点付きの数値を、Math.FloorとMath.Cellingを使い、
    /// 　　小数点以下を切り捨て、切り上げした値を求め、表示する
    /// 　③空の行を入力するまで繰り返す
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Min();
        }

        public static void Min()
        {
            //1回目の入力値
            var val1 = Console.ReadLine();
            var num1 = double.Parse(val1);
            //2回目の入力値
            var val2 = Console.ReadLine();
            var num2 = double.Parse(val2);
            //値を比較→小さい方の値を表示
            var min = Math.Min(num1,num2);
            Console.WriteLine($"最小値比較結果：{min}");
        }
    }
}

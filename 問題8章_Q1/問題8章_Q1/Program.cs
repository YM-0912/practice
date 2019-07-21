using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題8章_Q1
{
    /// <summary>
    /// 問題8章：静的メソッド／静的プロパティ／静的クラス
    /// 　①ArrayUtilsクラスにint型の配列の中から最大値を求めるMax静的メソッドを追加する
    /// 　　※この時配列には1つ以上の要素が必ず入っているものと仮定してOK
    /// 　②ArrayUtilsクラスにint型の配列の中から最小値を求めるMin静的メソッドを追加する
    /// 　　※この時配列には1つ以上の要素が必ず入っているものと仮定してOK
    /// 　③Maxメソッド、Minメソッドを使うコードを書いて正しく動作するか確認する
    /// </summary>
    static class ArrayUtils
    {

        public static void Main(string[] args)
        {
            var scores = new int[] { 55,60,45,70,85,93,68 };
            var Total = ArrayUtils.Total(scores);
            var Average = ArrayUtils.Average(scores);
            var Max = ArrayUtils.Max(scores);
            var Min = ArrayUtils.Min(scores);
            Console.WriteLine($"合計：{Total} 平均：{Average} 最大値：{Max} 最小値：{Min}");
        }

        //配列内の数値の合計を求める
        public static int Total(int[] numbers)
        {
            var total = 0;

            foreach (var n in numbers)
            {
                total += n;
            }

            return total;
        }

        //配列内の数値の平均を求める
        public static double Average(int[] numbers)
        {
            var total = Total(numbers);
            return (double)total / numbers.Length;
        }

        //配列の中から最大値を求める
        public static int Max(int[] numbers)
        {
            //最大値を代入する変数
            int numMax = numbers[0];

            foreach (var n in numbers)
            {
                if (numMax < n)
                {
                    numMax = n;
                }
            }

            return numMax;
        }

        //配列の中から最小値を求める
        public static int Min(int[] numbers)
        {
            //最小値を代入する変数
            int numMin = numbers[0];

            foreach(var n in numbers)
            {
                if (numMin > n)
                {
                    numMin = n;

                }
            }

            return numMin;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題8章_Q2
{
    /// <summary>
    /// 問題8章：静的メソッド／静的プロパティ／静的クラス
    /// 　①BmiCalculatorクラスを用意
    /// 　②GetBmiとGetBodyTypeの2つのメソッドを静的メソッドに変更する
    /// 　③①で変更したBmiCalculatorクラスを静的クラスに変更する
    /// 　④示されているコードを新しいBmiCalculaorクラスに合わせて書き換える
    /// </summary>
    static class BmiCalculator
    {
        static void Main(string[] args)
        {
            var bmi = BmiCalculator.GetBmi(158,45);
            var type = BmiCalculator.GetBodyType(bmi);
            Console.WriteLine($"あなたは「{type}」です。");
        }

        //BMI値を計算
        public static double GetBmi(double height, double weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }

        //体系のタイプ
        public static string GetBodyType(double bmi)
        {
            //体系のタイプを代入する変数
            var type = "";
            
            if(bmi < 18.5)
            {
                type = "痩せ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満(1度)";
            }
            else if (bmi < 35)
            {
                type = "肥満(2度)";
            }
            else if (bmi < 40)
            {
                type = "肥満(3度)";
            }
            else
            {
                type = "肥満(4度)";
            }

            return type;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題6章_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列の配列の中から最も文字数の多い文字列を出力する

            string[] strData = new string[5];

            strData[0] = "A";
            strData[1] = "AB";
            strData[2] = "ABC";
            strData[3] = "ABCD";
            strData[4] = "ABCDE";

            string strCheck = "";

            for (int i = 0; i < strData.Length; i++)
            {
                if(strData[i] != null)
                {
                    int lenResult = 0;
                    int len = strData[i].Length;    //文字数カウント

                    if(lenResult <= len)
                    {
                        lenResult = len;
                        strCheck = strData[i];
                    }

                }
            }

            Console.WriteLine($"最大文字数は{strCheck}です。");

            string max = "";
            foreach (string strData1 in strData)
            {
                if (strData1.Length >= max.Length)
                {
                    max = strData1;
                }
            }

            Console.WriteLine($"最大文字数は{max}です。");
        }
    }
}

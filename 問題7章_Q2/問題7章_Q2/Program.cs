using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題7章_Q2
{
    /// <summary>
    /// 第7章：クラス／オブジェクト指向プログラミングの基礎
    /// ①以下の4つのプロパティを持つ従業員を表すEmployeeクラスを定義する
    /// 　Id：従業員番号(int型)
    /// 　FamilyName：従業員の姓(string型)
    /// 　GivenName：従業員の名(string型)
    /// 　EmailAddress：Emailアドレス(string型)
    /// ②Employeeクラスに姓名を連結した値を返すGetFullNameメソッドを定義する
    /// 　姓と名の間には半角スペースを1つ入れること
    /// ③Employeeクラスのインスタンスを2つ生成し、それぞれのインスタンスに対し、GetFullNameを呼び出す
    /// 　その戻り値を表示する
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee()
            {
                Id = 0001,
                FamilyName = "田中",
                GivenName = "太郎",
                EmailAddress = "t.tanaka@biz.co.jp"
            };

            var employee2 = new Employee()
            {
                Id = 0002,
                FamilyName = "山田",
                GivenName = "花子",
                EmailAddress = "h.yamada@biz.co.jp"
            };

            Console.WriteLine(employee1.GetFullName());
            Console.WriteLine(employee2.GetFullName());
        }
    }

    /// <summary>
    /// 従業員を表すクラス
    /// </summary>
    class Employee
    {
        //プロパティ
        public int Id { get; set; }                 //従業員番号
        public string FamilyName { get; set; }      //従業員の姓
        public string GivenName { get; set; }       //従業員の名
        public string EmailAddress { get; set; }    //Emailアドレス

        /// <summary>
        /// 姓名を連結した値を返すメソッド
        /// </summary>
        public string GetFullName()
        {
            return $"{FamilyName} {GivenName}";
        }
    }
}

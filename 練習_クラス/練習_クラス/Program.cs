using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習_クラス
{
    /// <summary>
    /// CDのデータ
    /// </summary>
    class Program
    {
        //    static void Main(string[] args)
        //    {
        //        var cd1 = new Cd();
        //        {
        //            cd1.Artist ="Beatles";
        //            cd1.Title = "Abby Road";
        //            cd1.Price = 3000;
        //        }

        //        var cd2 = new Cd();
        //        {
        //            cd2.Artist = "Rolling Stones";
        //            cd2.Title = "The Rolling Stones";
        //            cd2.Price = 2000;
        //        }

        //        cd1.CdData();
        //        cd2.CdData();
        //    }
        //}

        ///// <summary>
        ///// CDのデータをコンソールに表示する
        ///// </summary>
        //class Cd
        //{
        //    public string Artist { get; set; }
        //    public string Title { get; set; }
        //    public int Price { get; set; }

        //    public void CdData()
        //    {
        //        Console.WriteLine($"アーティスト名：{this.Artist}");
        //        Console.WriteLine($"タイトル：{this.Title}");
        //        Console.WriteLine($"価格：{this.Price}");
        //    }
        //}

        //------------------再チャレンジ------------------

        static void Main(string[] args)
        {
            //CD情報
            //cd1：Beatles
            var cd1 = new Cd();
            {
                cd1.Artist = "The Beatles";
                cd1.Title = "White Album";
                cd1.Price = 5000;
            }

            //cd2：Zombies
            var cd2 = new Cd();
            {
                cd2.Artist = "The Zombies";
                cd2.Title = "Odessey & Oracle";
                cd2.Price = 3000;
            }

            //class Cdのメソッド呼び出し
            //cd1のCD情報を表示
            cd1.CdData();
            //cd2のCD情報を表示
            cd2.CdData();

            //2枚購入時の合計金額
            var total = new Cd();
            {
                int totalPrice = cd1.Price + cd2.Price;
                total.TotalPrice(totalPrice);
            }
        }

    }

    class Cd
    {
        //プロパティ設定

        public string Artist { get; set; }  //アーティスト名
        public string Title { get; set; }   //タイトル
        public int Price { get; set; }      //価格

        //処理：コンソールにCD情報を表示する
        public void CdData()
        {
            Console.WriteLine($"■アーティスト名：{this.Artist}");
            Console.WriteLine($"■タイトル：{this.Title}");
            Console.WriteLine($"■価格：{this.Price}");
        }

        //処理：2枚購入時の合計金額
        public void TotalPrice(int totalPrice)
        {
            Console.WriteLine($"合計金額は{totalPrice}円です。");
        }
    }
}

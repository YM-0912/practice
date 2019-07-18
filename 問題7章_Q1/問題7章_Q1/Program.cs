using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 問題7章_Q1
{
    /// <summary>
    /// 第7章：クラス／オブジェクト指向プログラミングの基礎
    /// ①リスト7-1のBookクラスにメモプロパティMemoを追加する　Memoの型はstring型
    /// ②Bookクラスのすべてのプロパティの値を表示するメソッドPrintを追加する
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book()
            {
                Title = "吾輩は猫である",
                Arthor = "夏目漱石",
                Pages = 610,
                Rating = 4,
                Memo = "江戸牛込馬場下横丁出身"

            };
            
            //↑の書き方の方が短くて良い
            //var book = new Book();

            //book.Title = "吾輩は猫である";
            //book.Arthor = "夏目漱石";
            //book.Pages = 610;
            //book.Rating = 4;
            //book.Memo = "江戸牛込馬場下横町出身";

            book.Print();
        }
    }

    class Book
    {
        public string Title { get; set; }       //タイトル
        public string Arthor { get; set; }      //著者
        public int Pages { get; set; }          //ページ数
        public int Rating { get; set; }         //評価
        public string Memo { get; set; }        //メモ　←①

        public void Print()
        {
            Console.WriteLine($"タイトル：{Title}");
            Console.WriteLine($"著者：{Arthor}");
            Console.WriteLine($"ページ数：{Pages}");
            Console.WriteLine($"評価：{Rating}");
            Console.WriteLine($"備考：{Memo}");
        }

    }
}

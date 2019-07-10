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
        static void Main(string[] args)
        {
            var cd1 = new Cd();
            {
                cd1.Artist ="Beatles";
                cd1.Title = "Abby Road";
                cd1.Price = 3000;
            }

            var cd2 = new Cd();
            {
                cd2.Artist = "Rolling Stones";
                cd2.Title = "The Rolling Stones";
                cd2.Price = 2000;
            }

            cd1.CdData();
            cd2.CdData();
        }
    }

    /// <summary>
    /// CDのデータをコンソールに表示する
    /// </summary>
    class Cd
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public void CdData()
        {
            Console.WriteLine($"アーティスト名：{this.Artist}");
            Console.WriteLine($"タイトル：{this.Title}");
            Console.WriteLine($"価格：{this.Price}");
        }
    }
}

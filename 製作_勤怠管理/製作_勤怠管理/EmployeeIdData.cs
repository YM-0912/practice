using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace 製作_勤怠管理
{
    
    /// <summary>
    /// 社員番号/PWを管理
    /// ※DBの代わり※
    /// </summary>
    class EmployeeIdData
    {
        //パラメータ
        public string Name { get; set; }        //氏名
        public string Number { get; set; }      //社員番号
        public string Pass { get; set; }        //パスワード

        public void Db(string number,string pass)
        {

            DataTable table = new DataTable();

            //カラム
            table.Columns.Add(Name);
            table.Columns.Add(Number);
            table.Columns.Add(Pass);

            //データを追加
            table.Rows.Add("田中一郎","0001","11111111");
            table.Rows.Add("山田二郎","0002","22222222");
            table.Rows.Add("木村三郎","0003","33333333");
            table.Rows.Add("大阪花子","0004","44444444");
            table.Rows.Add("神戸良子","0005","55555555");
            table.Rows.Add("岡山智子","0006","66666666");

            //データの一致・不一致を確認

            DataRow[] dRows = table.Select(Number,Pass);

            foreach (var row in dRows)
            {
                string row1 = (string)row[1];   //社員番号
                string row2 = (string)row[2];   //パスワード

                if (number == row1)
                {
                    //社員番号・パスワード共に一致した場合、メッセージを表示
                    if (pass == row2)
                    {
                        MessageBox.Show("一致しました");
                    }
                }
            }

            //該当しなかった場合、エラーメッセージを表示
            var error = new ErrorMessage();
            error.LoginError();
        }
    }
 }

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
    /// ログイン時の処理
    /// </summary>
    class LoginResult
    {
        //パラメータ
        public string EmployeeNumber { get; set; }      //社員番号
        public string PassWord { get; set; }            //パスワード

        //入力された社員番号とパスワードの一致・不一致を確認
        public void LoginCheck()
        {
            var login = new EmployeeIdData();

            login.Db(this.EmployeeNumber, this.PassWord);
        }
    }
}

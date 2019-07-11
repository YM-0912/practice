using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 製作_勤怠管理
{
    public partial class LoginField : Form
    {
        public LoginField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログインボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            //入力された社員番号・パスワードを変数に代入
            string emNumber = employeeIdTextBox.Text;
            string emPassword = PasswordTextBox.Text;

            //LoginResultクラスのインスタンスを生成
            var login = new LoginResult();

            login.EmployeeNumber = emNumber;
            login.PassWord = emPassword;

            login.LoginCheck();
        }
    }

}

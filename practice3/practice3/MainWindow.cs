using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //ResistrationWindowのインスタンスを生成
        ResistrationWindow f = new ResistrationWindow();

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void resistrationWindowbutton_Click(object sender, EventArgs e)
        {
            //モーダルフォームで入力画面を表示する
            //オーナーウィンドウを指定
            f.ShowDialog(this);
        }
    }
}

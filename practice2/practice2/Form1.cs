using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //エラー処理
        private void errorMsg()
        {
            MessageBox.Show("負の値を入力して下さい。");
        }

        //入力された値が負であるか否かを確認する処理
        private void button1_Click(object sender, EventArgs e)
        {

                int number = int.Parse(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show($"負の値{number}が入力されました。");
                    //break;
                }
                else
                {
                    errorMsg();
                    //break;
                }
        }



    }
}

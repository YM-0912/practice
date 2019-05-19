using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        //税額を計算する処理
        static int taxCalc(string inputWord)
        {
            double tax = 0.08;  //税額
            int taxPrice;//計算結果

            var castWord = int.Parse(inputWord);
            taxPrice = (int)(castWord * tax);

            return taxPrice;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ボタンを押下した時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            string inputWord = textBox1.Text;
            int taxPrice = taxCalc(inputWord);
            MessageBox.Show($"税額は{taxPrice}円です。");
        }
    }
}

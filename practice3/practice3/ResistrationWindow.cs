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
    public partial class ResistrationWindow : Form
    {
        public ResistrationWindow()
        {
            InitializeComponent();
        }

        private void ResistrationWindow_Load(object sender, EventArgs e)
        {
        }

        //登録ボタンクリック時の処理
        private void registrationbutton_Click(object sender, EventArgs e)
        {            

           //収支選択
           string inOut = InAndOut();
           //項目選択
           string item = Items();
           //金額
           int price = InputPrice();
           string pr = price.ToString();

            //var inputDataList = new string[3] { inOut, item, pr };

            if (inOut != "" && item != "" && pr != "0")
            {
                MessageBox.Show("登録が完了しました");
                this.Close();
            }
            else
            {
                Error();
            }

        }

        //収支選択
        public string InAndOut()
        {
            string inAndOutWord = "";

            if (incomeButton.Checked == true)
            {
                inAndOutWord = "収入";

            }else if(spendingButton.Checked == true){
                inAndOutWord = "支出";
            }
            else
            {
                Error();
            }

            return inAndOutWord;
        }

        //項目選択
        public string Items()
        {
            string choose = "";          //選択した項目
            //string rent = "";           //家賃
            //string utility = "";        //光熱費
            //string food = "";           //食費
            //string goods = "";          //日用雑貨
            //string entartainment = "";  //交際費

            choose = itemChooseBox.Text;
            return choose;
        }

        //金額入力
        public int InputPrice()
        {
            int pr = 0;     //入力した金額

            pr = int.Parse(priceInputBox.Text);
            return pr;
        }

        //エラー処理
        public void Error()
        {
            MessageBox.Show("正しい値を入力して下さい。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }


    }
}

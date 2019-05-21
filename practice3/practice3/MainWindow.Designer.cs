namespace practice3
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savingMoneyLabel = new System.Windows.Forms.Label();
            this.spendingMoneyLabel = new System.Windows.Forms.Label();
            this.resistrationWindowbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "貯金：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "支出合計：";
            // 
            // savingMoneyLabel
            // 
            this.savingMoneyLabel.AutoSize = true;
            this.savingMoneyLabel.Location = new System.Drawing.Point(174, 31);
            this.savingMoneyLabel.Name = "savingMoneyLabel";
            this.savingMoneyLabel.Size = new System.Drawing.Size(62, 18);
            this.savingMoneyLabel.TabIndex = 2;
            this.savingMoneyLabel.Text = "？？？";
            // 
            // spendingMoneyLabel
            // 
            this.spendingMoneyLabel.AutoSize = true;
            this.spendingMoneyLabel.Location = new System.Drawing.Point(174, 81);
            this.spendingMoneyLabel.Name = "spendingMoneyLabel";
            this.spendingMoneyLabel.Size = new System.Drawing.Size(62, 18);
            this.spendingMoneyLabel.TabIndex = 3;
            this.spendingMoneyLabel.Text = "？？？";
            // 
            // resistrationWindowbutton
            // 
            this.resistrationWindowbutton.Location = new System.Drawing.Point(589, 352);
            this.resistrationWindowbutton.Name = "resistrationWindowbutton";
            this.resistrationWindowbutton.Size = new System.Drawing.Size(115, 54);
            this.resistrationWindowbutton.TabIndex = 4;
            this.resistrationWindowbutton.Text = "入力";
            this.resistrationWindowbutton.UseVisualStyleBackColor = true;
            this.resistrationWindowbutton.Click += new System.EventHandler(this.resistrationWindowbutton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.resistrationWindowbutton);
            this.Controls.Add(this.spendingMoneyLabel);
            this.Controls.Add(this.savingMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "家計簿";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label savingMoneyLabel;
        private System.Windows.Forms.Label spendingMoneyLabel;
        private System.Windows.Forms.Button resistrationWindowbutton;
    }
}


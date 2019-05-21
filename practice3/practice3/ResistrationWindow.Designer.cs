namespace practice3
{
    partial class ResistrationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.RadioButton();
            this.spendingButton = new System.Windows.Forms.RadioButton();
            this.priceInputBox = new System.Windows.Forms.TextBox();
            this.itemChooseBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "収支選択：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "項目選択：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "金額　　：";
            // 
            // registrationbutton
            // 
            this.registrationbutton.Location = new System.Drawing.Point(583, 354);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(116, 54);
            this.registrationbutton.TabIndex = 3;
            this.registrationbutton.Text = "登録";
            this.registrationbutton.UseVisualStyleBackColor = true;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.AutoSize = true;
            this.incomeButton.Location = new System.Drawing.Point(158, 40);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(69, 22);
            this.incomeButton.TabIndex = 4;
            this.incomeButton.TabStop = true;
            this.incomeButton.Text = "収入";
            this.incomeButton.UseVisualStyleBackColor = true;
            // 
            // spendingButton
            // 
            this.spendingButton.AutoSize = true;
            this.spendingButton.Checked = true;
            this.spendingButton.Location = new System.Drawing.Point(263, 40);
            this.spendingButton.Name = "spendingButton";
            this.spendingButton.Size = new System.Drawing.Size(69, 22);
            this.spendingButton.TabIndex = 5;
            this.spendingButton.TabStop = true;
            this.spendingButton.Text = "支出";
            this.spendingButton.UseVisualStyleBackColor = true;
            // 
            // priceInputBox
            // 
            this.priceInputBox.Location = new System.Drawing.Point(157, 203);
            this.priceInputBox.Name = "priceInputBox";
            this.priceInputBox.Size = new System.Drawing.Size(175, 25);
            this.priceInputBox.TabIndex = 7;
            // 
            // itemChooseBox
            // 
            this.itemChooseBox.FormattingEnabled = true;
            this.itemChooseBox.Items.AddRange(new object[] {
            "家賃",
            "光熱費",
            "食費",
            "日用雑貨",
            "交際費"});
            this.itemChooseBox.Location = new System.Drawing.Point(157, 120);
            this.itemChooseBox.Name = "itemChooseBox";
            this.itemChooseBox.Size = new System.Drawing.Size(175, 26);
            this.itemChooseBox.TabIndex = 8;
            // 
            // ResistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.itemChooseBox);
            this.Controls.Add(this.priceInputBox);
            this.Controls.Add(this.spendingButton);
            this.Controls.Add(this.incomeButton);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResistrationWindow";
            this.Text = "登録画面";
            this.Load += new System.EventHandler(this.ResistrationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrationbutton;
        private System.Windows.Forms.RadioButton incomeButton;
        private System.Windows.Forms.RadioButton spendingButton;
        private System.Windows.Forms.TextBox priceInputBox;
        private System.Windows.Forms.ComboBox itemChooseBox;
    }
}
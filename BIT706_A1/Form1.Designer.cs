
namespace BIT706_A1
{
    partial class Form1
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
            this.RadioButtonBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.InfoButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.AccountInput = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.InterestButton = new System.Windows.Forms.Button();
            this.RadioButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButtonBox
            // 
            this.RadioButtonBox.Controls.Add(this.radioButton3);
            this.RadioButtonBox.Controls.Add(this.radioButton2);
            this.RadioButtonBox.Controls.Add(this.radioButton1);
            this.RadioButtonBox.Location = new System.Drawing.Point(48, 39);
            this.RadioButtonBox.Name = "RadioButtonBox";
            this.RadioButtonBox.Size = new System.Drawing.Size(200, 100);
            this.RadioButtonBox.TabIndex = 0;
            this.RadioButtonBox.TabStop = false;
            this.RadioButtonBox.Text = "Accounts";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Omni";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Investment";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Everyday";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(55, 211);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(75, 23);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(55, 257);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 2;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(55, 304);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(136, 23);
            this.WithdrawButton.TabIndex = 3;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // AccountInput
            // 
            this.AccountInput.Location = new System.Drawing.Point(229, 257);
            this.AccountInput.Name = "AccountInput";
            this.AccountInput.Size = new System.Drawing.Size(100, 22);
            this.AccountInput.TabIndex = 4;
            this.AccountInput.Text = "0.00";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(229, 234);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(56, 17);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Information";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1130, 152);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // OutputBox
            // 
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.ItemHeight = 16;
            this.OutputBox.Location = new System.Drawing.Point(170, 46);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(1035, 100);
            this.OutputBox.TabIndex = 10;
            // 
            // InterestButton
            // 
            this.InterestButton.Location = new System.Drawing.Point(55, 343);
            this.InterestButton.Name = "InterestButton";
            this.InterestButton.Size = new System.Drawing.Size(136, 23);
            this.InterestButton.TabIndex = 11;
            this.InterestButton.Text = "Add Interest";
            this.InterestButton.UseVisualStyleBackColor = true;
            this.InterestButton.Click += new System.EventHandler(this.InterestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 407);
            this.Controls.Add(this.InterestButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.AccountInput);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.RadioButtonBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RadioButtonBox.ResumeLayout(false);
            this.RadioButtonBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RadioButtonBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.TextBox AccountInput;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Button InterestButton;
    }
}


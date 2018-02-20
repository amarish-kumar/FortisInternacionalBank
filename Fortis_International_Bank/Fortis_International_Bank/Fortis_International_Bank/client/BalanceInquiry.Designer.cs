namespace Fortis_International_Bank.client
{
    partial class BalanceInquiry
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.AcclistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransacListView = new System.Windows.Forms.ListView();
            this.TransactionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentBalancetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxWithdraw = new System.Windows.Forms.CheckBox();
            this.checkBoxDeposit = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewBalanceTextBox = new System.Windows.Forms.TextBox();
            this.TransactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccNumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TransactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(358, 504);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(249, 27);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AcclistView
            // 
            this.AcclistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.AcclistView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AcclistView.FullRowSelect = true;
            this.AcclistView.GridLines = true;
            this.AcclistView.Location = new System.Drawing.Point(78, 28);
            this.AcclistView.Name = "AcclistView";
            this.AcclistView.Size = new System.Drawing.Size(809, 112);
            this.AcclistView.TabIndex = 2;
            this.AcclistView.UseCompatibleStateImageBehavior = false;
            this.AcclistView.View = System.Windows.Forms.View.Details;
            this.AcclistView.SelectedIndexChanged += new System.EventHandler(this.AcclistView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account Number";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account Type";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opening Date";
            this.columnHeader3.Width = 185;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balance";
            this.columnHeader4.Width = 281;
            // 
            // TransacListView
            // 
            this.TransacListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionNumber,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader9});
            this.TransacListView.FullRowSelect = true;
            this.TransacListView.GridLines = true;
            this.TransacListView.Location = new System.Drawing.Point(78, 155);
            this.TransacListView.Name = "TransacListView";
            this.TransacListView.Size = new System.Drawing.Size(809, 116);
            this.TransacListView.TabIndex = 3;
            this.TransacListView.UseCompatibleStateImageBehavior = false;
            this.TransacListView.View = System.Windows.Forms.View.Details;
            // 
            // TransactionNumber
            // 
            this.TransactionNumber.Text = "Transaction Number";
            this.TransactionNumber.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transaction Type";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Account Number";
            this.columnHeader7.Width = 149;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Account Type";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Transaction Date";
            this.columnHeader5.Width = 197;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 122;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(508, 343);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(216, 20);
            this.AmountTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Balance:";
            // 
            // CurrentBalancetextBox
            // 
            this.CurrentBalancetextBox.Location = new System.Drawing.Point(508, 304);
            this.CurrentBalancetextBox.Name = "CurrentBalancetextBox";
            this.CurrentBalancetextBox.ReadOnly = true;
            this.CurrentBalancetextBox.Size = new System.Drawing.Size(216, 20);
            this.CurrentBalancetextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amount:";
            // 
            // TransactionGroupBox
            // 
            this.TransactionGroupBox.Controls.Add(this.checkBoxWithdraw);
            this.TransactionGroupBox.Controls.Add(this.checkBoxDeposit);
            this.TransactionGroupBox.Location = new System.Drawing.Point(154, 329);
            this.TransactionGroupBox.Name = "TransactionGroupBox";
            this.TransactionGroupBox.Size = new System.Drawing.Size(239, 43);
            this.TransactionGroupBox.TabIndex = 92;
            this.TransactionGroupBox.TabStop = false;
            this.TransactionGroupBox.Text = "Transaction Type";
            // 
            // checkBoxWithdraw
            // 
            this.checkBoxWithdraw.AutoSize = true;
            this.checkBoxWithdraw.Location = new System.Drawing.Point(41, 17);
            this.checkBoxWithdraw.Name = "checkBoxWithdraw";
            this.checkBoxWithdraw.Size = new System.Drawing.Size(71, 17);
            this.checkBoxWithdraw.TabIndex = 22;
            this.checkBoxWithdraw.Text = "Withdraw";
            this.checkBoxWithdraw.UseVisualStyleBackColor = true;
            this.checkBoxWithdraw.CheckedChanged += new System.EventHandler(this.checkBoxWithdraw_CheckedChanged);
            // 
            // checkBoxDeposit
            // 
            this.checkBoxDeposit.AutoSize = true;
            this.checkBoxDeposit.Location = new System.Drawing.Point(156, 17);
            this.checkBoxDeposit.Name = "checkBoxDeposit";
            this.checkBoxDeposit.Size = new System.Drawing.Size(62, 17);
            this.checkBoxDeposit.TabIndex = 23;
            this.checkBoxDeposit.Text = "Deposit";
            this.checkBoxDeposit.UseVisualStyleBackColor = true;
            this.checkBoxDeposit.CheckedChanged += new System.EventHandler(this.checkBoxDeposit_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "New Balance:";
            // 
            // NewBalanceTextBox
            // 
            this.NewBalanceTextBox.Location = new System.Drawing.Point(507, 383);
            this.NewBalanceTextBox.Name = "NewBalanceTextBox";
            this.NewBalanceTextBox.ReadOnly = true;
            this.NewBalanceTextBox.Size = new System.Drawing.Size(216, 20);
            this.NewBalanceTextBox.TabIndex = 94;
            // 
            // TransactionNumberTextBox
            // 
            this.TransactionNumberTextBox.Location = new System.Drawing.Point(195, 383);
            this.TransactionNumberTextBox.Name = "TransactionNumberTextBox";
            this.TransactionNumberTextBox.ReadOnly = true;
            this.TransactionNumberTextBox.Size = new System.Drawing.Size(216, 20);
            this.TransactionNumberTextBox.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Transaction Number:";
            // 
            // AccNumTextBox
            // 
            this.AccNumTextBox.Location = new System.Drawing.Point(195, 304);
            this.AccNumTextBox.Name = "AccNumTextBox";
            this.AccNumTextBox.ReadOnly = true;
            this.AccNumTextBox.Size = new System.Drawing.Size(214, 20);
            this.AccNumTextBox.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Account Number:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(745, 304);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(142, 95);
            this.ConfirmButton.TabIndex = 99;
            this.ConfirmButton.Text = "Confirm Transaction";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(358, 443);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(249, 23);
            this.ResetButton.TabIndex = 100;
            this.ResetButton.Text = "Reset / Make new Transaction";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BalanceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 543);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.AccNumTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransactionNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewBalanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactionGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurrentBalancetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.TransacListView);
            this.Controls.Add(this.AcclistView);
            this.Controls.Add(this.CloseButton);
            this.Name = "BalanceInquiry";
            this.Text = "IBanking";
            this.Load += new System.EventHandler(this.BalanceInquiry_Load);
            this.TransactionGroupBox.ResumeLayout(false);
            this.TransactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView AcclistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView TransacListView;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentBalancetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TransactionGroupBox;
        private System.Windows.Forms.CheckBox checkBoxWithdraw;
        private System.Windows.Forms.CheckBox checkBoxDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewBalanceTextBox;
        private System.Windows.Forms.TextBox TransactionNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccNumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ColumnHeader TransactionNumber;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button ResetButton;
    }
}
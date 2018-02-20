namespace Fortis_International_Bank.client
{
    partial class InitialForm
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
            this.customerButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.IDmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PinLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.PINtextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Fortis Intenational Bank Inc.";
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.customerButton.Location = new System.Drawing.Point(636, 252);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(494, 215);
            this.customerButton.TabIndex = 4;
            this.customerButton.Text = "I\'m a Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.managerButton.Location = new System.Drawing.Point(73, 252);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(494, 215);
            this.managerButton.TabIndex = 3;
            this.managerButton.Text = "I\'m a Manager!";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1021, 499);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // IDmaskedTextBox
            // 
            this.IDmaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IDmaskedTextBox.Location = new System.Drawing.Point(607, 108);
            this.IDmaskedTextBox.Mask = "0000";
            this.IDmaskedTextBox.Name = "IDmaskedTextBox";
            this.IDmaskedTextBox.Size = new System.Drawing.Size(82, 44);
            this.IDmaskedTextBox.TabIndex = 8;
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.PinLabel.Location = new System.Drawing.Point(510, 161);
            this.PinLabel.Name = "PinLabel";
            this.PinLabel.Size = new System.Drawing.Size(79, 37);
            this.PinLabel.TabIndex = 12;
            this.PinLabel.Text = "PIN:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.idLabel.Location = new System.Drawing.Point(510, 111);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 37);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // PINtextBox
            // 
            this.PINtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.PINtextBox.Location = new System.Drawing.Point(607, 154);
            this.PINtextBox.Mask = "0000";
            this.PINtextBox.Name = "PINtextBox";
            this.PINtextBox.Size = new System.Drawing.Size(82, 44);
            this.PINtextBox.TabIndex = 13;
            this.PINtextBox.UseSystemPasswordChar = true;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 605);
            this.Controls.Add(this.PINtextBox);
            this.Controls.Add(this.IDmaskedTextBox);
            this.Controls.Add(this.PinLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.managerButton);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MaskedTextBox IDmaskedTextBox;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.MaskedTextBox PINtextBox;
    }
}
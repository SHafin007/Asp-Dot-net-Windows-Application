namespace BankTransactionApp
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
            this.AccountCreationgroupBox = new System.Windows.Forms.GroupBox();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.CustomerNamelabel = new System.Windows.Forms.Label();
            this.AccountNumberlabel = new System.Windows.Forms.Label();
            this.TransactiongroupBox = new System.Windows.Forms.GroupBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.WithDrawbutton = new System.Windows.Forms.Button();
            this.Depositbutton = new System.Windows.Forms.Button();
            this.Reportbutton = new System.Windows.Forms.Button();
            this.AccountCreationgroupBox.SuspendLayout();
            this.TransactiongroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountCreationgroupBox
            // 
            this.AccountCreationgroupBox.Controls.Add(this.AccountNumberTextBox);
            this.AccountCreationgroupBox.Controls.Add(this.AccountNameTextBox);
            this.AccountCreationgroupBox.Controls.Add(this.Createbutton);
            this.AccountCreationgroupBox.Controls.Add(this.CustomerNamelabel);
            this.AccountCreationgroupBox.Controls.Add(this.AccountNumberlabel);
            this.AccountCreationgroupBox.Location = new System.Drawing.Point(42, 37);
            this.AccountCreationgroupBox.Name = "AccountCreationgroupBox";
            this.AccountCreationgroupBox.Size = new System.Drawing.Size(362, 127);
            this.AccountCreationgroupBox.TabIndex = 0;
            this.AccountCreationgroupBox.TabStop = false;
            this.AccountCreationgroupBox.Text = "Account Creation";
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Location = new System.Drawing.Point(100, 26);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(221, 20);
            this.AccountNumberTextBox.TabIndex = 6;
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Location = new System.Drawing.Point(100, 56);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(221, 20);
            this.AccountNameTextBox.TabIndex = 5;
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(113, 94);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(118, 23);
            this.Createbutton.TabIndex = 3;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // CustomerNamelabel
            // 
            this.CustomerNamelabel.AutoSize = true;
            this.CustomerNamelabel.Location = new System.Drawing.Point(7, 59);
            this.CustomerNamelabel.Name = "CustomerNamelabel";
            this.CustomerNamelabel.Size = new System.Drawing.Size(82, 13);
            this.CustomerNamelabel.TabIndex = 1;
            this.CustomerNamelabel.Text = "Customer Name";
            // 
            // AccountNumberlabel
            // 
            this.AccountNumberlabel.AutoSize = true;
            this.AccountNumberlabel.Location = new System.Drawing.Point(7, 29);
            this.AccountNumberlabel.Name = "AccountNumberlabel";
            this.AccountNumberlabel.Size = new System.Drawing.Size(87, 13);
            this.AccountNumberlabel.TabIndex = 0;
            this.AccountNumberlabel.Text = "Account Number";
            // 
            // TransactiongroupBox
            // 
            this.TransactiongroupBox.Controls.Add(this.AmountTextBox);
            this.TransactiongroupBox.Controls.Add(this.Amountlabel);
            this.TransactiongroupBox.Controls.Add(this.WithDrawbutton);
            this.TransactiongroupBox.Controls.Add(this.Depositbutton);
            this.TransactiongroupBox.Location = new System.Drawing.Point(42, 184);
            this.TransactiongroupBox.Name = "TransactiongroupBox";
            this.TransactiongroupBox.Size = new System.Drawing.Size(362, 90);
            this.TransactiongroupBox.TabIndex = 1;
            this.TransactiongroupBox.TabStop = false;
            this.TransactiongroupBox.Text = "Transaction Account";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(100, 12);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(221, 20);
            this.AmountTextBox.TabIndex = 3;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Location = new System.Drawing.Point(17, 20);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(46, 13);
            this.Amountlabel.TabIndex = 2;
            this.Amountlabel.Text = "Amount ";
            // 
            // WithDrawbutton
            // 
            this.WithDrawbutton.Location = new System.Drawing.Point(205, 55);
            this.WithDrawbutton.Name = "WithDrawbutton";
            this.WithDrawbutton.Size = new System.Drawing.Size(116, 23);
            this.WithDrawbutton.TabIndex = 1;
            this.WithDrawbutton.Text = "WithDraw ";
            this.WithDrawbutton.UseVisualStyleBackColor = true;
            this.WithDrawbutton.Click += new System.EventHandler(this.WithDrawbutton_Click);
            // 
            // Depositbutton
            // 
            this.Depositbutton.Location = new System.Drawing.Point(83, 55);
            this.Depositbutton.Name = "Depositbutton";
            this.Depositbutton.Size = new System.Drawing.Size(116, 23);
            this.Depositbutton.TabIndex = 0;
            this.Depositbutton.Text = "Deposit";
            this.Depositbutton.UseVisualStyleBackColor = true;
            this.Depositbutton.Click += new System.EventHandler(this.Depositbutton_Click);
            // 
            // Reportbutton
            // 
            this.Reportbutton.Location = new System.Drawing.Point(155, 291);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(166, 23);
            this.Reportbutton.TabIndex = 2;
            this.Reportbutton.Text = "Report";
            this.Reportbutton.UseVisualStyleBackColor = true;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 329);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.TransactiongroupBox);
            this.Controls.Add(this.AccountCreationgroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AccountCreationgroupBox.ResumeLayout(false);
            this.AccountCreationgroupBox.PerformLayout();
            this.TransactiongroupBox.ResumeLayout(false);
            this.TransactiongroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountCreationgroupBox;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Label CustomerNamelabel;
        private System.Windows.Forms.Label AccountNumberlabel;
        private System.Windows.Forms.GroupBox TransactiongroupBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Button WithDrawbutton;
        private System.Windows.Forms.Button Depositbutton;
        private System.Windows.Forms.Button Reportbutton;
    }
}


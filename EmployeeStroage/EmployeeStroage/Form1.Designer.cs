namespace EmployeeStroage
{
    partial class EmployeeInformationForm
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
            this.EmployeeIDlabel = new System.Windows.Forms.Label();
            this.EmployeeNamelable = new System.Windows.Forms.Label();
            this.EmployeeSalarylable = new System.Windows.Forms.Label();
            this.EmployeeIDtextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeSalarytextBox = new System.Windows.Forms.TextBox();
            this.Showbutton = new System.Windows.Forms.Button();
            this.Retrivebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeIDlabel
            // 
            this.EmployeeIDlabel.AutoSize = true;
            this.EmployeeIDlabel.Location = new System.Drawing.Point(50, 49);
            this.EmployeeIDlabel.Name = "EmployeeIDlabel";
            this.EmployeeIDlabel.Size = new System.Drawing.Size(18, 13);
            this.EmployeeIDlabel.TabIndex = 0;
            this.EmployeeIDlabel.Text = "ID";
            // 
            // EmployeeNamelable
            // 
            this.EmployeeNamelable.AutoSize = true;
            this.EmployeeNamelable.Location = new System.Drawing.Point(47, 87);
            this.EmployeeNamelable.Name = "EmployeeNamelable";
            this.EmployeeNamelable.Size = new System.Drawing.Size(35, 13);
            this.EmployeeNamelable.TabIndex = 1;
            this.EmployeeNamelable.Text = "Name";
            // 
            // EmployeeSalarylable
            // 
            this.EmployeeSalarylable.AutoSize = true;
            this.EmployeeSalarylable.Location = new System.Drawing.Point(46, 130);
            this.EmployeeSalarylable.Name = "EmployeeSalarylable";
            this.EmployeeSalarylable.Size = new System.Drawing.Size(36, 13);
            this.EmployeeSalarylable.TabIndex = 2;
            this.EmployeeSalarylable.Text = "Salary";
            // 
            // EmployeeIDtextBox
            // 
            this.EmployeeIDtextBox.Location = new System.Drawing.Point(126, 49);
            this.EmployeeIDtextBox.Name = "EmployeeIDtextBox";
            this.EmployeeIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDtextBox.TabIndex = 3;
            // 
            // EmployeeNametextBox
            // 
            this.EmployeeNametextBox.Location = new System.Drawing.Point(126, 87);
            this.EmployeeNametextBox.Name = "EmployeeNametextBox";
            this.EmployeeNametextBox.Size = new System.Drawing.Size(139, 20);
            this.EmployeeNametextBox.TabIndex = 4;
            // 
            // EmployeeSalarytextBox
            // 
            this.EmployeeSalarytextBox.Location = new System.Drawing.Point(126, 123);
            this.EmployeeSalarytextBox.Name = "EmployeeSalarytextBox";
            this.EmployeeSalarytextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSalarytextBox.TabIndex = 5;
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(49, 169);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(109, 23);
            this.Showbutton.TabIndex = 6;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // Retrivebutton
            // 
            this.Retrivebutton.Location = new System.Drawing.Point(164, 169);
            this.Retrivebutton.Name = "Retrivebutton";
            this.Retrivebutton.Size = new System.Drawing.Size(114, 23);
            this.Retrivebutton.TabIndex = 7;
            this.Retrivebutton.Text = "Retrive";
            this.Retrivebutton.UseVisualStyleBackColor = true;
            this.Retrivebutton.Click += new System.EventHandler(this.Retrivebutton_Click);
            // 
            // EmployeeInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 230);
            this.Controls.Add(this.Retrivebutton);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.EmployeeSalarytextBox);
            this.Controls.Add(this.EmployeeNametextBox);
            this.Controls.Add(this.EmployeeIDtextBox);
            this.Controls.Add(this.EmployeeSalarylable);
            this.Controls.Add(this.EmployeeNamelable);
            this.Controls.Add(this.EmployeeIDlabel);
            this.Name = "EmployeeInformationForm";
            this.Text = "Employee Information UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeIDlabel;
        private System.Windows.Forms.Label EmployeeNamelable;
        private System.Windows.Forms.Label EmployeeSalarylable;
        private System.Windows.Forms.TextBox EmployeeIDtextBox;
        private System.Windows.Forms.TextBox EmployeeNametextBox;
        private System.Windows.Forms.TextBox EmployeeSalarytextBox;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button Retrivebutton;
    }
}


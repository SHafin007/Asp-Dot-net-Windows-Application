namespace SimpleCalculator
{
    partial class Calculator
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
            this.claculatorgroupbox = new System.Windows.Forms.GroupBox();
            this.FirstNumberlable = new System.Windows.Forms.Label();
            this.SecondNumberlable = new System.Windows.Forms.Label();
            this.Resultlable = new System.Windows.Forms.Label();
            this.firstNmuberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.claculatorgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // claculatorgroupbox
            // 
            this.claculatorgroupbox.Controls.Add(this.ModButton);
            this.claculatorgroupbox.Controls.Add(this.DivButton);
            this.claculatorgroupbox.Controls.Add(this.MultButton);
            this.claculatorgroupbox.Controls.Add(this.MinusButton);
            this.claculatorgroupbox.Controls.Add(this.AddButton);
            this.claculatorgroupbox.Controls.Add(this.ResultTextBox);
            this.claculatorgroupbox.Controls.Add(this.secondNumberTextBox);
            this.claculatorgroupbox.Controls.Add(this.firstNmuberTextBox);
            this.claculatorgroupbox.Controls.Add(this.Resultlable);
            this.claculatorgroupbox.Controls.Add(this.SecondNumberlable);
            this.claculatorgroupbox.Controls.Add(this.FirstNumberlable);
            this.claculatorgroupbox.Location = new System.Drawing.Point(39, 43);
            this.claculatorgroupbox.Name = "claculatorgroupbox";
            this.claculatorgroupbox.Size = new System.Drawing.Size(305, 188);
            this.claculatorgroupbox.TabIndex = 0;
            this.claculatorgroupbox.TabStop = false;
            this.claculatorgroupbox.Text = "Calculator";
            // 
            // FirstNumberlable
            // 
            this.FirstNumberlable.AutoSize = true;
            this.FirstNumberlable.Location = new System.Drawing.Point(7, 29);
            this.FirstNumberlable.Name = "FirstNumberlable";
            this.FirstNumberlable.Size = new System.Drawing.Size(66, 13);
            this.FirstNumberlable.TabIndex = 0;
            this.FirstNumberlable.Text = "First Number";
            // 
            // SecondNumberlable
            // 
            this.SecondNumberlable.AutoSize = true;
            this.SecondNumberlable.Location = new System.Drawing.Point(10, 62);
            this.SecondNumberlable.Name = "SecondNumberlable";
            this.SecondNumberlable.Size = new System.Drawing.Size(84, 13);
            this.SecondNumberlable.TabIndex = 1;
            this.SecondNumberlable.Text = "Second Number";
            // 
            // Resultlable
            // 
            this.Resultlable.AutoSize = true;
            this.Resultlable.Location = new System.Drawing.Point(10, 160);
            this.Resultlable.Name = "Resultlable";
            this.Resultlable.Size = new System.Drawing.Size(37, 13);
            this.Resultlable.TabIndex = 2;
            this.Resultlable.Text = "Result";
            // 
            // firstNmuberTextBox
            // 
            this.firstNmuberTextBox.Location = new System.Drawing.Point(147, 29);
            this.firstNmuberTextBox.Name = "firstNmuberTextBox";
            this.firstNmuberTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNmuberTextBox.TabIndex = 3;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(147, 56);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumberTextBox.TabIndex = 4;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(147, 152);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(74, 99);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(28, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(108, 99);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(29, 23);
            this.MinusButton.TabIndex = 7;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Location = new System.Drawing.Point(143, 99);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(30, 23);
            this.MultButton.TabIndex = 8;
            this.MultButton.Text = "*";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Location = new System.Drawing.Point(179, 99);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(31, 23);
            this.DivButton.TabIndex = 9;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(216, 99);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(33, 23);
            this.ModButton.TabIndex = 10;
            this.ModButton.Text = "%";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 270);
            this.Controls.Add(this.claculatorgroupbox);
            this.Name = "Calculator";
            this.Text = "Simple calculator UI";
            this.claculatorgroupbox.ResumeLayout(false);
            this.claculatorgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox claculatorgroupbox;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNmuberTextBox;
        private System.Windows.Forms.Label Resultlable;
        private System.Windows.Forms.Label SecondNumberlable;
        private System.Windows.Forms.Label FirstNumberlable;
    }
}


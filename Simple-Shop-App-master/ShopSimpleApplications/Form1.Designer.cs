namespace ShopSimpleApplications
{
    partial class ShopForm
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
            this.ShopInfogroupBox = new System.Windows.Forms.GroupBox();
            this.ShopNameTextBox = new System.Windows.Forms.TextBox();
            this.ShopSavebutton = new System.Windows.Forms.Button();
            this.ShopAddresslabel = new System.Windows.Forms.Label();
            this.ShopNamelabel = new System.Windows.Forms.Label();
            this.ShopAddressrichTextBox = new System.Windows.Forms.RichTextBox();
            this.ProductInfogroupBox = new System.Windows.Forms.GroupBox();
            this.ProductSavebutton = new System.Windows.Forms.Button();
            this.ProductQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ProductCompanyTextBox = new System.Windows.Forms.TextBox();
            this.ProductItemIdtexTBox = new System.Windows.Forms.TextBox();
            this.ProductQuantitylabel = new System.Windows.Forms.Label();
            this.ProductCompanylabel = new System.Windows.Forms.Label();
            this.Product_itemlabel = new System.Windows.Forms.Label();
            this.Showbutton = new System.Windows.Forms.Button();
            this.ShopInfogroupBox.SuspendLayout();
            this.ProductInfogroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopInfogroupBox
            // 
            this.ShopInfogroupBox.Controls.Add(this.ShopNameTextBox);
            this.ShopInfogroupBox.Controls.Add(this.ShopSavebutton);
            this.ShopInfogroupBox.Controls.Add(this.ShopAddresslabel);
            this.ShopInfogroupBox.Controls.Add(this.ShopNamelabel);
            this.ShopInfogroupBox.Controls.Add(this.ShopAddressrichTextBox);
            this.ShopInfogroupBox.Location = new System.Drawing.Point(12, 12);
            this.ShopInfogroupBox.Name = "ShopInfogroupBox";
            this.ShopInfogroupBox.Size = new System.Drawing.Size(342, 147);
            this.ShopInfogroupBox.TabIndex = 0;
            this.ShopInfogroupBox.TabStop = false;
            this.ShopInfogroupBox.Text = "Shop Information";
            // 
            // ShopNameTextBox
            // 
            this.ShopNameTextBox.Location = new System.Drawing.Point(89, 20);
            this.ShopNameTextBox.Name = "ShopNameTextBox";
            this.ShopNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.ShopNameTextBox.TabIndex = 4;
            // 
            // ShopSavebutton
            // 
            this.ShopSavebutton.Location = new System.Drawing.Point(154, 108);
            this.ShopSavebutton.Name = "ShopSavebutton";
            this.ShopSavebutton.Size = new System.Drawing.Size(75, 23);
            this.ShopSavebutton.TabIndex = 3;
            this.ShopSavebutton.Text = "Save";
            this.ShopSavebutton.UseVisualStyleBackColor = true;
            this.ShopSavebutton.Click += new System.EventHandler(this.ShopSavebutton_Click);
            // 
            // ShopAddresslabel
            // 
            this.ShopAddresslabel.AutoSize = true;
            this.ShopAddresslabel.Location = new System.Drawing.Point(15, 69);
            this.ShopAddresslabel.Name = "ShopAddresslabel";
            this.ShopAddresslabel.Size = new System.Drawing.Size(45, 13);
            this.ShopAddresslabel.TabIndex = 2;
            this.ShopAddresslabel.Text = "Address";
            // 
            // ShopNamelabel
            // 
            this.ShopNamelabel.AutoSize = true;
            this.ShopNamelabel.Location = new System.Drawing.Point(12, 22);
            this.ShopNamelabel.Name = "ShopNamelabel";
            this.ShopNamelabel.Size = new System.Drawing.Size(69, 13);
            this.ShopNamelabel.TabIndex = 1;
            this.ShopNamelabel.Text = "Shope Name";
            // 
            // ShopAddressrichTextBox
            // 
            this.ShopAddressrichTextBox.Location = new System.Drawing.Point(89, 51);
            this.ShopAddressrichTextBox.Name = "ShopAddressrichTextBox";
            this.ShopAddressrichTextBox.Size = new System.Drawing.Size(238, 51);
            this.ShopAddressrichTextBox.TabIndex = 0;
            this.ShopAddressrichTextBox.Text = "";
            // 
            // ProductInfogroupBox
            // 
            this.ProductInfogroupBox.Controls.Add(this.ProductSavebutton);
            this.ProductInfogroupBox.Controls.Add(this.ProductQuantityTextBox);
            this.ProductInfogroupBox.Controls.Add(this.ProductCompanyTextBox);
            this.ProductInfogroupBox.Controls.Add(this.ProductItemIdtexTBox);
            this.ProductInfogroupBox.Controls.Add(this.ProductQuantitylabel);
            this.ProductInfogroupBox.Controls.Add(this.ProductCompanylabel);
            this.ProductInfogroupBox.Controls.Add(this.Product_itemlabel);
            this.ProductInfogroupBox.Location = new System.Drawing.Point(12, 165);
            this.ProductInfogroupBox.Name = "ProductInfogroupBox";
            this.ProductInfogroupBox.Size = new System.Drawing.Size(342, 121);
            this.ProductInfogroupBox.TabIndex = 1;
            this.ProductInfogroupBox.TabStop = false;
            this.ProductInfogroupBox.Text = "Product Information";
            // 
            // ProductSavebutton
            // 
            this.ProductSavebutton.Location = new System.Drawing.Point(252, 76);
            this.ProductSavebutton.Name = "ProductSavebutton";
            this.ProductSavebutton.Size = new System.Drawing.Size(75, 23);
            this.ProductSavebutton.TabIndex = 6;
            this.ProductSavebutton.Text = "Save";
            this.ProductSavebutton.UseVisualStyleBackColor = true;
            this.ProductSavebutton.Click += new System.EventHandler(this.ProductSavebutton_Click);
            // 
            // ProductQuantityTextBox
            // 
            this.ProductQuantityTextBox.Location = new System.Drawing.Point(96, 76);
            this.ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            this.ProductQuantityTextBox.Size = new System.Drawing.Size(149, 20);
            this.ProductQuantityTextBox.TabIndex = 5;
            // 
            // ProductCompanyTextBox
            // 
            this.ProductCompanyTextBox.Location = new System.Drawing.Point(97, 49);
            this.ProductCompanyTextBox.Name = "ProductCompanyTextBox";
            this.ProductCompanyTextBox.Size = new System.Drawing.Size(234, 20);
            this.ProductCompanyTextBox.TabIndex = 4;
            // 
            // ProductItemIdtexTBox
            // 
            this.ProductItemIdtexTBox.Location = new System.Drawing.Point(97, 20);
            this.ProductItemIdtexTBox.Name = "ProductItemIdtexTBox";
            this.ProductItemIdtexTBox.Size = new System.Drawing.Size(145, 20);
            this.ProductItemIdtexTBox.TabIndex = 3;
            // 
            // ProductQuantitylabel
            // 
            this.ProductQuantitylabel.AutoSize = true;
            this.ProductQuantitylabel.Location = new System.Drawing.Point(8, 78);
            this.ProductQuantitylabel.Name = "ProductQuantitylabel";
            this.ProductQuantitylabel.Size = new System.Drawing.Size(46, 13);
            this.ProductQuantitylabel.TabIndex = 2;
            this.ProductQuantitylabel.Text = "Quantity";
            // 
            // ProductCompanylabel
            // 
            this.ProductCompanylabel.AutoSize = true;
            this.ProductCompanylabel.Location = new System.Drawing.Point(4, 52);
            this.ProductCompanylabel.Name = "ProductCompanylabel";
            this.ProductCompanylabel.Size = new System.Drawing.Size(91, 13);
            this.ProductCompanylabel.TabIndex = 1;
            this.ProductCompanylabel.Text = "Product Company";
            // 
            // Product_itemlabel
            // 
            this.Product_itemlabel.AutoSize = true;
            this.Product_itemlabel.Location = new System.Drawing.Point(5, 23);
            this.Product_itemlabel.Name = "Product_itemlabel";
            this.Product_itemlabel.Size = new System.Drawing.Size(81, 13);
            this.Product_itemlabel.TabIndex = 0;
            this.Product_itemlabel.Text = "Product/Item Id";
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(166, 302);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(75, 23);
            this.Showbutton.TabIndex = 2;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 336);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.ProductInfogroupBox);
            this.Controls.Add(this.ShopInfogroupBox);
            this.Name = "ShopForm";
            this.Text = "Shop UI";
            this.ShopInfogroupBox.ResumeLayout(false);
            this.ShopInfogroupBox.PerformLayout();
            this.ProductInfogroupBox.ResumeLayout(false);
            this.ProductInfogroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ShopInfogroupBox;
        private System.Windows.Forms.RichTextBox ShopAddressrichTextBox;
        private System.Windows.Forms.GroupBox ProductInfogroupBox;
        private System.Windows.Forms.TextBox ShopNameTextBox;
        private System.Windows.Forms.Button ShopSavebutton;
        private System.Windows.Forms.Label ShopAddresslabel;
        private System.Windows.Forms.Label ShopNamelabel;
        private System.Windows.Forms.Button ProductSavebutton;
        private System.Windows.Forms.TextBox ProductQuantityTextBox;
        private System.Windows.Forms.TextBox ProductCompanyTextBox;
        private System.Windows.Forms.TextBox ProductItemIdtexTBox;
        private System.Windows.Forms.Label ProductQuantitylabel;
        private System.Windows.Forms.Label ProductCompanylabel;
        private System.Windows.Forms.Label Product_itemlabel;
        private System.Windows.Forms.Button Showbutton;
    }
}


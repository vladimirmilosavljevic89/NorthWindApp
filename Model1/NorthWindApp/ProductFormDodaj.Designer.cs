namespace NorthWindApp
{
    partial class ProductFormDodaj
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textSupplierID = new System.Windows.Forms.TextBox();
            this.textCategoryID = new System.Windows.Forms.TextBox();
            this.textQuantityPErUnit = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.textUnitsInStock = new System.Windows.Forms.TextBox();
            this.textUnitsOnOrded = new System.Windows.Forms.TextBox();
            this.textReorderLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDiscontinued = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(35, 429);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(181, 37);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(297, 429);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(181, 37);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(198, 26);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(217, 22);
            this.textProductName.TabIndex = 2;
            // 
            // textSupplierID
            // 
            this.textSupplierID.Location = new System.Drawing.Point(198, 76);
            this.textSupplierID.Name = "textSupplierID";
            this.textSupplierID.Size = new System.Drawing.Size(217, 22);
            this.textSupplierID.TabIndex = 3;
            // 
            // textCategoryID
            // 
            this.textCategoryID.Location = new System.Drawing.Point(198, 122);
            this.textCategoryID.Name = "textCategoryID";
            this.textCategoryID.Size = new System.Drawing.Size(217, 22);
            this.textCategoryID.TabIndex = 5;
            // 
            // textQuantityPErUnit
            // 
            this.textQuantityPErUnit.Location = new System.Drawing.Point(198, 170);
            this.textQuantityPErUnit.Name = "textQuantityPErUnit";
            this.textQuantityPErUnit.Size = new System.Drawing.Size(217, 22);
            this.textQuantityPErUnit.TabIndex = 6;
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(198, 221);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.Size = new System.Drawing.Size(217, 22);
            this.textUnitPrice.TabIndex = 7;
            // 
            // textUnitsInStock
            // 
            this.textUnitsInStock.Location = new System.Drawing.Point(198, 262);
            this.textUnitsInStock.Name = "textUnitsInStock";
            this.textUnitsInStock.Size = new System.Drawing.Size(217, 22);
            this.textUnitsInStock.TabIndex = 8;
            // 
            // textUnitsOnOrded
            // 
            this.textUnitsOnOrded.Location = new System.Drawing.Point(198, 309);
            this.textUnitsOnOrded.Name = "textUnitsOnOrded";
            this.textUnitsOnOrded.Size = new System.Drawing.Size(217, 22);
            this.textUnitsOnOrded.TabIndex = 9;
            // 
            // textReorderLevel
            // 
            this.textReorderLevel.Location = new System.Drawing.Point(198, 355);
            this.textReorderLevel.Name = "textReorderLevel";
            this.textReorderLevel.Size = new System.Drawing.Size(217, 22);
            this.textReorderLevel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ProductName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "SupplierID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "CategoryID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity Per Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Units in Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Units On Order";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Reorder Level";
            // 
            // textDiscontinued
            // 
            this.textDiscontinued.Location = new System.Drawing.Point(198, 392);
            this.textDiscontinued.Name = "textDiscontinued";
            this.textDiscontinued.Size = new System.Drawing.Size(217, 22);
            this.textDiscontinued.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Discontinued";
            // 
            // ProductFormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 478);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textDiscontinued);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReorderLevel);
            this.Controls.Add(this.textUnitsOnOrded);
            this.Controls.Add(this.textUnitsInStock);
            this.Controls.Add(this.textUnitPrice);
            this.Controls.Add(this.textQuantityPErUnit);
            this.Controls.Add(this.textCategoryID);
            this.Controls.Add(this.textSupplierID);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "ProductFormDodaj";
            this.Text = "ProductFormDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textSupplierID;
        private System.Windows.Forms.TextBox textCategoryID;
        private System.Windows.Forms.TextBox textQuantityPErUnit;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.TextBox textUnitsInStock;
        private System.Windows.Forms.TextBox textUnitsOnOrded;
        private System.Windows.Forms.TextBox textReorderLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDiscontinued;
        private System.Windows.Forms.Label label10;
    }
}
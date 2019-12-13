namespace NorthWindApp
{
    partial class ProductForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textsupplierId = new System.Windows.Forms.TextBox();
            this.textCategoryID = new System.Windows.Forms.TextBox();
            this.textQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.textUnitsInStock = new System.Windows.Forms.TextBox();
            this.textUnitsOnOrder = new System.Windows.Forms.TextBox();
            this.textReorderLevel = new System.Windows.Forms.TextBox();
            this.textDiscontinued = new System.Windows.Forms.TextBox();
            this.btnPotvrdiIzmeni = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(777, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(523, 548);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(16, 40);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(224, 22);
            this.textProductName.TabIndex = 1;
            // 
            // textsupplierId
            // 
            this.textsupplierId.Location = new System.Drawing.Point(16, 78);
            this.textsupplierId.Name = "textsupplierId";
            this.textsupplierId.Size = new System.Drawing.Size(224, 22);
            this.textsupplierId.TabIndex = 2;
            // 
            // textCategoryID
            // 
            this.textCategoryID.Location = new System.Drawing.Point(16, 117);
            this.textCategoryID.Name = "textCategoryID";
            this.textCategoryID.Size = new System.Drawing.Size(224, 22);
            this.textCategoryID.TabIndex = 3;
            // 
            // textQuantityPerUnit
            // 
            this.textQuantityPerUnit.Location = new System.Drawing.Point(16, 160);
            this.textQuantityPerUnit.Name = "textQuantityPerUnit";
            this.textQuantityPerUnit.Size = new System.Drawing.Size(224, 22);
            this.textQuantityPerUnit.TabIndex = 4;
            this.textQuantityPerUnit.TextChanged += new System.EventHandler(this.textQuantityPerUnit_TextChanged);
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(16, 205);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.Size = new System.Drawing.Size(224, 22);
            this.textUnitPrice.TabIndex = 5;
            // 
            // textUnitsInStock
            // 
            this.textUnitsInStock.Location = new System.Drawing.Point(16, 250);
            this.textUnitsInStock.Name = "textUnitsInStock";
            this.textUnitsInStock.Size = new System.Drawing.Size(224, 22);
            this.textUnitsInStock.TabIndex = 6;
            // 
            // textUnitsOnOrder
            // 
            this.textUnitsOnOrder.Location = new System.Drawing.Point(16, 291);
            this.textUnitsOnOrder.Name = "textUnitsOnOrder";
            this.textUnitsOnOrder.Size = new System.Drawing.Size(224, 22);
            this.textUnitsOnOrder.TabIndex = 7;
            // 
            // textReorderLevel
            // 
            this.textReorderLevel.Location = new System.Drawing.Point(16, 334);
            this.textReorderLevel.Name = "textReorderLevel";
            this.textReorderLevel.Size = new System.Drawing.Size(224, 22);
            this.textReorderLevel.TabIndex = 8;
            // 
            // textDiscontinued
            // 
            this.textDiscontinued.Location = new System.Drawing.Point(16, 375);
            this.textDiscontinued.Name = "textDiscontinued";
            this.textDiscontinued.Size = new System.Drawing.Size(224, 22);
            this.textDiscontinued.TabIndex = 9;
            // 
            // btnPotvrdiIzmeni
            // 
            this.btnPotvrdiIzmeni.Location = new System.Drawing.Point(63, 511);
            this.btnPotvrdiIzmeni.Name = "btnPotvrdiIzmeni";
            this.btnPotvrdiIzmeni.Size = new System.Drawing.Size(180, 28);
            this.btnPotvrdiIzmeni.TabIndex = 10;
            this.btnPotvrdiIzmeni.Text = "Potvrdi Izmenu";
            this.btnPotvrdiIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(304, 511);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(184, 28);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(63, 588);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(180, 28);
            this.btndodaj.TabIndex = 13;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(526, 588);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(180, 28);
            this.btnObrisi.TabIndex = 15;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "SupplierID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity Per Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "UnitPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "UnitsInStock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "UnitsOnOrder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Reorder Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Discontinued";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textProductName);
            this.groupBox1.Controls.Add(this.textsupplierId);
            this.groupBox1.Controls.Add(this.textCategoryID);
            this.groupBox1.Controls.Add(this.textQuantityPerUnit);
            this.groupBox1.Controls.Add(this.textUnitPrice);
            this.groupBox1.Controls.Add(this.textUnitsInStock);
            this.groupBox1.Controls.Add(this.textUnitsOnOrder);
            this.groupBox1.Controls.Add(this.textReorderLevel);
            this.groupBox1.Controls.Add(this.textDiscontinued);
            this.groupBox1.Location = new System.Drawing.Point(407, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 403);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdiIzmeni);
            this.Controls.Add(this.listBox1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textsupplierId;
        private System.Windows.Forms.TextBox textCategoryID;
        private System.Windows.Forms.TextBox textQuantityPerUnit;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.TextBox textUnitsInStock;
        private System.Windows.Forms.TextBox textUnitsOnOrder;
        private System.Windows.Forms.TextBox textReorderLevel;
        private System.Windows.Forms.TextBox textDiscontinued;
        private System.Windows.Forms.Button btnPotvrdiIzmeni;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
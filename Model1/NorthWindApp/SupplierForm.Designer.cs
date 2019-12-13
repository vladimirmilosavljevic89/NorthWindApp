namespace NorthWindApp
{
    partial class SupplierForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxcontactName = new System.Windows.Forms.TextBox();
            this.textBoxcontactTitle = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxHomePage = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonPotvrdiIzmeni = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(450, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(151, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxcontactName
            // 
            this.textBoxcontactName.Location = new System.Drawing.Point(151, 79);
            this.textBoxcontactName.Name = "textBoxcontactName";
            this.textBoxcontactName.Size = new System.Drawing.Size(205, 22);
            this.textBoxcontactName.TabIndex = 1;
            // 
            // textBoxcontactTitle
            // 
            this.textBoxcontactTitle.Location = new System.Drawing.Point(151, 118);
            this.textBoxcontactTitle.Name = "textBoxcontactTitle";
            this.textBoxcontactTitle.Size = new System.Drawing.Size(205, 22);
            this.textBoxcontactTitle.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(151, 158);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(205, 22);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(151, 201);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(205, 22);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(151, 238);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(205, 22);
            this.textBoxRegion.TabIndex = 5;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(151, 277);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(205, 22);
            this.textBoxPostalCode.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxHomePage);
            this.groupBox1.Controls.Add(this.textBoxFax);
            this.groupBox1.Controls.Add(this.textBoxphone);
            this.groupBox1.Controls.Add(this.textBoxCountry);
            this.groupBox1.Controls.Add(this.textBoxPostalCode);
            this.groupBox1.Controls.Add(this.textBoxRegion);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxcontactTitle);
            this.groupBox1.Controls.Add(this.textBoxcontactName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(151, 315);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(205, 22);
            this.textBoxCountry.TabIndex = 7;
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(151, 353);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(205, 22);
            this.textBoxphone.TabIndex = 8;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(151, 394);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(205, 22);
            this.textBoxFax.TabIndex = 9;
            // 
            // textBoxHomePage
            // 
            this.textBoxHomePage.Location = new System.Drawing.Point(151, 439);
            this.textBoxHomePage.Name = "textBoxHomePage";
            this.textBoxHomePage.Size = new System.Drawing.Size(205, 22);
            this.textBoxHomePage.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(89, 684);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(142, 33);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "dodaj ";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(526, 684);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(142, 33);
            this.buttonObrisi.TabIndex = 3;
            this.buttonObrisi.Text = "izbrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(302, 684);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(142, 33);
            this.buttonIzmeni.TabIndex = 4;
            this.buttonIzmeni.Text = "izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            // 
            // buttonPotvrdiIzmeni
            // 
            this.buttonPotvrdiIzmeni.Location = new System.Drawing.Point(100, 593);
            this.buttonPotvrdiIzmeni.Name = "buttonPotvrdiIzmeni";
            this.buttonPotvrdiIzmeni.Size = new System.Drawing.Size(142, 33);
            this.buttonPotvrdiIzmeni.TabIndex = 10;
            this.buttonPotvrdiIzmeni.Text = "Potvrdi izmenu";
            this.buttonPotvrdiIzmeni.UseVisualStyleBackColor = true;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(302, 593);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(142, 33);
            this.buttonOdustani.TabIndex = 11;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CompanyName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ContactName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ContactTitle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 442);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Home Page";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 756);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPotvrdiIzmeni);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxcontactName;
        private System.Windows.Forms.TextBox textBoxcontactTitle;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHomePage;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonPotvrdiIzmeni;
        private System.Windows.Forms.Button buttonOdustani;
    }
}
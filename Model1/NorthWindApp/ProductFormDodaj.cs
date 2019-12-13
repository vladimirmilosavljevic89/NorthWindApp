using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model1;
using DAL1.Interfaces.Repository;

namespace NorthWindApp
{
    public partial class ProductFormDodaj : Form
    {
        public ProductFormDodaj()
        {
            InitializeComponent();
        }

        private ProductRepository rep = new ProductRepository();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            try
            {
                product.ProductName1 = textProductName.Text;
                product.CategoryID1 = Convert.ToInt32(textCategoryID.Text);
                product.SupplierID1 = Convert.ToInt32(textSupplierID.Text);
                product.QuantityPerUnit1 = textQuantityPErUnit.Text;
                product.UnitPrice1 = Convert.ToInt32(textUnitPrice.Text);
                product.UnitsInStock1 = Convert.ToInt16(textUnitsInStock.Text);
                product.UnitsOnOrder1 = Convert.ToInt16(textUnitsOnOrded.Text);
                product.ReorderLevel1 = Convert.ToInt16(textReorderLevel.Text);
                product.Discontinued1 = Convert.ToBoolean(textDiscontinued.Text);

            }
            catch
            {
                MessageBox.Show("Greska pri unosu podataka", "Greska");
                return;
            }
            int rez = rep.AddProducts(product);
            if (rez==0)
            {
                MessageBox.Show("Uspesno ubacen produkt", "Poruka");
                textProductName.Text = "";
                textCategoryID.Text = "";
                textSupplierID.Text = "";
                textQuantityPErUnit.Text = "";
                textUnitPrice.Text = "";
                textUnitsInStock.Text = "";
                textUnitsOnOrded.Text = "";
                textReorderLevel.Text = "";
                textDiscontinued.Text = "";


            }
            else
            {
                MessageBox.Show("Greska pri radu sa bazom", "Poruka");
            }
            this.Close();
        }
    }
}

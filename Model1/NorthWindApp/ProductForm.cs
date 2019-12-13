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
    public partial class ProductForm : Form
    {
        private List<Product> listaProdukata = new List<Product>();
        private ProductRepository repository = new ProductRepository();
        public ProductForm()
        {
            InitializeComponent();
        }
        private void Dozvoli(bool dozvola)


        {
            groupBox1.Enabled = dozvola;
            btndodaj.Visible = !dozvola;
            btnPotvrdiIzmeni.Visible = !dozvola;
            btnOdustani.Visible = dozvola;
            btnObrisi.Visible = !dozvola;

        }
        private void napuniListuProdukata()
        {
            listaProdukata = repository.GetAllProducts();
            listBox1.DataSource = listaProdukata;
            listBox1.DisplayMember = "ProductName1";
            listBox1.ValueMember ="ProductID1";



        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            napuniListuProdukata();
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
                listBox1.SelectedIndex = -1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int poz = listBox1.SelectedIndex;
            textProductName.Text = listaProdukata[poz].ProductName1;
            textsupplierId.Text = listaProdukata[poz].SupplierID1.ToString();
            textCategoryID.Text = listaProdukata[poz].CategoryID1.ToString();
            textQuantityPerUnit.Text = listaProdukata[poz].QuantityPerUnit1;
            textUnitPrice.Text = listaProdukata[poz].UnitPrice1.ToString();
            textUnitsInStock.Text = listaProdukata[poz].UnitsInStock1.ToString();
            textUnitsOnOrder.Text = listaProdukata[poz].UnitsOnOrder1.ToString();
            textReorderLevel.Text = listaProdukata[poz].ReorderLevel1.ToString();
            textDiscontinued.Text = listaProdukata[poz].Discontinued1.ToString();

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            ProductFormDodaj pfd = new ProductFormDodaj();
            Dozvoli(false);
            pfd.ShowDialog();
            pfd.Dispose();
            napuniListuProdukata();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void textQuantityPerUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductID1 = Convert.ToInt32(listBox1.SelectedValue);

            product.ProductName1 = textProductName.Text;
            product.CategoryID1 = Convert.ToInt32(textCategoryID.Text);
            product.SupplierID1 = Convert.ToInt32(textsupplierId.Text);
            product.QuantityPerUnit1 = textQuantityPerUnit.Text;
            product.UnitPrice1 = Convert.ToDecimal(textUnitPrice.Text);
            product.UnitsInStock1 = Convert.ToInt16(textUnitsInStock.Text);
            product.UnitsOnOrder1 = Convert.ToInt16(textUnitsOnOrder.Text);
            product.ReorderLevel1 = Convert.ToInt16(textReorderLevel.Text);
            product.Discontinued1 = Convert.ToBoolean(textDiscontinued.Text);
            int rez = repository.UpdateProducts(product);
            if (rez == 0)
            {
                napuniListuProdukata();
                MessageBox.Show("uspesno ste izmenili produkt", "Produkt promenjen");

            }
            else
            {
                MessageBox.Show("Greska");
            }
            listBox1.SelectedValue = product.ProductID1;
            Dozvoli(false);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Dozvoli(false);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int poz = listBox1.SelectedIndex;
            if (MessageBox.Show("Da li ste sigurni da zelite brisanje?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int rez = repository.DeleteProducts(listaProdukata[poz]);
                if (rez == 0)
                {
                    napuniListuProdukata();
                    listBox1.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("ne mozete obrisati produkt");

                }
            }
        }
    }

}

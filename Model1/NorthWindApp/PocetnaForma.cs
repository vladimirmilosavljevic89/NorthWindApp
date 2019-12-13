using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindApp
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm form = new SupplierForm();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

            ProductForm product = new ProductForm();
            product.ShowDialog();
            product.Dispose();
        }
    }
}

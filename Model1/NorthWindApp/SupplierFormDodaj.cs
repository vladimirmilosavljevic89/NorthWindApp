using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL1.Interfaces.Repository;
using Model1;

namespace NorthWindApp
{
    public partial class SupplierFormDodaj : Form
    {
        public SupplierFormDodaj()
        {
            InitializeComponent();
        }
        private SupplierRepository repository = new SupplierRepository();

        private void btnDOdaj_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
        }
    }
}

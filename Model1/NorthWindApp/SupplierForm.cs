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
    public partial class SupplierForm : Form
    {

        private List<Supplier> lista = new List<Supplier>();
        private SupplierRepository repository = new SupplierRepository();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void Dozvoli (bool dozvola)
        {
            groupBox1.Enabled = dozvola;
            buttonPotvrdiIzmeni.Visible = dozvola;
            buttonOdustani.Visible = dozvola;
            buttonDodaj.Visible = !dozvola;
            buttonIzmeni.Visible = !dozvola;
            buttonObrisi.Visible = !dozvola;

        }
        private void napuniListuSuppliera()
        {
            lista = repository.GetAllSuppliers();
            listBox1.DataSource = lista;
            listBox1.DisplayMember = "CompanyName1";
            listBox1.ValueMember = "SupplierID1";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            napuniListuSuppliera();
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
            else
            {
                listBox1.SelectedIndex = -1;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int poz = listBox1.SelectedIndex;
            textBoxName.Text = lista[poz].CompanyName1;
            textBoxcontactName.Text = lista[poz].ContactName1;
            textBoxcontactTitle.Text = lista[poz].ContactTitle1;
            textBoxAddress.Text = lista[poz].Address1;
            textBoxCountry.Text = lista[poz].Country1;
            textBoxFax.Text = lista[poz].Fax1;
            textBoxHomePage.Text = lista[poz].HomePage1;
            textBoxRegion.Text = lista[poz].Region1;
            textBoxPostalCode.Text = lista[poz].PostalCode1;
            textBoxCity.Text = lista[poz].City1;
            textBoxphone.Text = lista[poz].Phone1;

           
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            SupplierFormDodaj form = new SupplierFormDodaj();
            Dozvoli(false);
            form.ShowDialog();
            form.Dispose();
            napuniListuSuppliera();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}

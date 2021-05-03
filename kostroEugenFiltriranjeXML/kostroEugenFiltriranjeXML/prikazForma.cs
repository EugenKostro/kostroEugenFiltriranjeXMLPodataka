using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kostroEugenFiltriranjeXML
{
    public partial class prikazForma : Form
    {
        public static string Ime = "";
        public static string Prezime = "";
        public static string Email = "";
        public static string Razred = "";
        public prikazForma()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            Ime = textBoxIme2.Text;
            Prezime = textBoxPrezime2.Text;
            Email = textBoxEmail2.Text;
            Razred = (string)comboBoxRazred2.SelectedItem;
            this.Hide();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prikazForma_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kostroEugenFiltriranjeXML
{
    public partial class unosForma : Form
    {
        List<Osoba> osobaLista = new List<Osoba>();
        public unosForma()
        {
            InitializeComponent();
        }

        private void unosForma_Load(object sender, EventArgs e)
        {

        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            var xmlFiltriranjeDokument = new XDocument(new XElement("osobaLista",
                from Osoba in osobaLista
                select new XElement("Osoba",
                new XElement("Ime", Osoba.Ime1),
                new XElement("Prezime", Osoba.Prezime1),
                new XElement("Email", Osoba.Email1),
                new XElement("Razred", Osoba.Razred1))));

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxIme.Text) || string.IsNullOrEmpty(textBoxPrezime.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(comboBoxRazred.Text))
            {
                MessageBox.Show("Nisu ispunjeni svi podaci!");
                return;
            }

            Osoba osoba = new Osoba(textBoxIme.Text, textBoxPrezime.Text, textBoxEmail.Text, comboBoxRazred.Text);
            osobaLista.Add(osoba);

            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxEmail.Clear();
            comboBoxRazred.Text = " ";

            string dir = @"D:\Documents\xmlDocument";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}

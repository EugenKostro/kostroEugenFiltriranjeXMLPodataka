using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kostroEugenFiltriranjeXML
{
    public partial class pregledPodataka : Form
    {
        public pregledPodataka()
        {
            InitializeComponent();
        }

        private void btnOdustani2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUcitajDokument_Click(object sender, EventArgs e)
        {
            XElement ucitajPodatak = XElement.Load(@"D:/Documents/xmlDokument/pretraga12.xml");
            IEnumerable<XElement> osobe = from Osoba in ucitajPodatak.Descendants("Osoba") select Osoba;
            
            foreach (var item in osobe)
            {
                richTextBox1.Text += item.ToString() + " \n";
            }
        }

        private void btnFiltriraj2_Click(object sender, EventArgs e)
        {
            prikazForma frm = new prikazForma();
            frm.Show();
            XElement ucitajPodatak = XElement.Load(@"D:/Documents/xmlDokument/pretraga12.xml");
            IEnumerable<XElement> osobe = from Osoba in ucitajPodatak.Descendants("Osoba")
                                          where (string)Osoba.Element("Ime") == prikazForma.Ime && (string)Osoba.Element("Prezime") == prikazForma.Prezime && (string)Osoba.Element("Email") == prikazForma.Email && (string)Osoba.Element("Razred") == prikazForma.Razred select Osoba;


            foreach (var item in osobe)
            {
                richTextBox1.Text += item.ToString() + " \n";
            }
            

            
        }
    }
}

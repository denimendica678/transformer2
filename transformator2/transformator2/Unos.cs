using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace transformator2
{
    public partial class Unos : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        String putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "csvTransformerPodatci");

        public Unos()
        {
            InitializeComponent();
        }

        private void btnZavrsiUnosPodataka_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(putanja))
            {
                Directory.CreateDirectory(putanja);
            }

            StreamWriter sw = new StreamWriter(putanja + "/podatci.csv");

            sw.WriteLine("Ime,Prezime,Mail,Razred");

            foreach(Ucenik uc in listaUcenika)
            {
                sw.WriteLine(uc.Ispis());
            }

            sw.Close();

            Form1 frmPocetna = new Form1();
            frmPocetna.Show();
            this.Hide();
        }

        private void btnUnosUnosPodataka_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailUnosPodataka.Text.Contains('@'))
                {
                    Ucenik objUcenik = new Ucenik(txtImeUnosPodataka.Text, txtPrezimeUnosPodataka.Text,
                        txtEmailUnosPodataka.Text, cmbRazredUnosPodataka.Text);
                    
                    listaUcenika.Add(objUcenik);

                    txtEmailUnosPodataka.Clear();
                    txtImeUnosPodataka.Clear();
                    txtPrezimeUnosPodataka.Clear();



                    MessageBox.Show("Podatci su uneseni", "Unos OK", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Unesite ispravnu e-mail adresu", "Unos nije OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška!");
            }
        }
    }
}

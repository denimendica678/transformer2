using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transformator2.Properties
{
    public partial class Pocetna : Form
    {

        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnUnosTansformer_Click(object sender, EventArgs e)
        {
            Unos frmUnos = new Unos();
            frmUnos.Show();
        }

        private void btnPregledTansformer_Click(object sender, EventArgs e)
        {
            Pregled frmPregled = new Pregled();
            frmPregled.Show();
            this.Hide();
        }
    }
}

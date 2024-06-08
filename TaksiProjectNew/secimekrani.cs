using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksiProjectNew
{
    public partial class secimekrani : Form
    {
        public secimekrani()
        {
            InitializeComponent();
        }

        private void btnGirisEkraniYon_Click(object sender, EventArgs e)
        {
            admingiris agiris = new admingiris();
            agiris.ShowDialog();
            this.Hide();
        }

        private void btnKayitEkraniYon_Click(object sender, EventArgs e)
        {
            adminkayit akayit = new adminkayit();
            akayit.ShowDialog();
            this.Hide();
        }
    }
}

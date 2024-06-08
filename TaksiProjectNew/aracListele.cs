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
    public partial class aracListele : Form
    {
        public aracListele()
        {
            InitializeComponent();
        }

        private void aracListele_Load(object sender, EventArgs e)
        {
            aracliste();
        }

        private void aracliste()
        {
            
            
                using (TaksiTakipEntities ent = new TaksiTakipEntities())
                {
                    var musteriler = from m in ent.ARACLAR select new { m.PLAKA, m.ARACSAHIBI, m.ARACSAHIBITELEFON, m.ACIKLAMA };
                    dataGridView1.DataSource = musteriler.ToList();
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

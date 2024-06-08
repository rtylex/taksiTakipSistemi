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
    public partial class cagriyap : Form
    {
        public cagriyap()
        {
            InitializeComponent();
        }

        private void btnTaksiCagir_Click(object sender, EventArgs e)
        {
            taksicagir();
        }

        private void taksicagir()
        {

            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                CAGRILAR cekle = new CAGRILAR();
                cekle.TARİHSAAT = DateTime.Parse (mtbTarih.Text);
                cekle.MUSTERID =  int.Parse(txtMusteriId.Text);
                cekle.ARACID = int.Parse(txtAracId.Text);
                cekle.SOFORID = int.Parse(txtSoforId.Text);
                cekle.NOT = rtbNot.Text;
                
                ent.CAGRILAR.Add(cekle);
                ent.SaveChanges();
                MessageBox.Show("ÇAĞRI EKLENDİ");

            }
        }

        private void rtbNot_TextChanged(object sender, EventArgs e)
        {

        }

        private void cagriyap_Load(object sender, EventArgs e)
        {
            musteriidlistele();
            aracidlistele();
            soforidlistele();
            aktifaracsoforlistele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriidlistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var musteriler = from m in ent.MUSTERILER select new { m.MUSTERIID };
                dataGridView1.DataSource = musteriler.ToList();
            }
        }
        private void aracidlistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var araclar = from m in ent.ARACLAR select new { m.ARACID };
                dataGridView2.DataSource = araclar.ToList();
            }
        }

        private void aktifaracsoforlistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var araclar = from m in ent.CAGRILAR select new { m.CAGRIID,m.SOFORID,m.ARACID };
                dataGridView4.DataSource = araclar.ToList();
            }
        }
        private void soforidlistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var soforler = from m in ent.SOFORLER select new { m.SOFORID,m.CALISMADURUMU };
                dataGridView3.DataSource = soforler.ToList();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gelencagri gc = new gelencagri();
            gc.ShowDialog();
        }
    }
}

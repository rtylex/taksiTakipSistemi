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
    public partial class aracEkran : Form
    {
        public aracEkran()
        {
            InitializeComponent();
        }

        private void aracEkran_Load(object sender, EventArgs e)
        {
            araclistele();
        }

        private void araclistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var musteriler = from m in ent.ARACLAR select new { m.PLAKA,m.ARACSAHIBI,m.ARACSAHIBITELEFON,m.ACIKLAMA };
                dgvAraclar.DataSource = musteriler.ToList();
            }
        }

        

        private void dgvAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aracKayit()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {

                ARACLAR aekle = new ARACLAR();
                aekle.PLAKA = txtPlaka.Text;
                aekle.ARACSAHIBI = txtAracSahibi.Text;
                aekle.ARACSAHIBITELEFON = decimal.Parse(mtbAracSahibiTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")); ;
                aekle.ACIKLAMA = rtbAcıklama.Text;

                ent.ARACLAR.Add(aekle);
                ent.SaveChanges();
                MessageBox.Show("ARAC   EKLENDİ");
                araclistele();
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            aracKayit();
        }

       

         private void btnAracSil_Click(object sender, EventArgs e)
        {
            aracsil();
        }



        private void aracGuncelle()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {

                try
                {
                    if (dgvAraclar.SelectedRows.Count != 0)
                    {
                        int secilenAracId = Convert.ToInt32(dgvAraclar.CurrentRow.Cells[0].Value.ToString());
                        var aBilgi = ent.ARACLAR.Where(w => w.ARACID == secilenAracId).FirstOrDefault();
                        aBilgi.PLAKA = txtPlaka.Text;
                        aBilgi.ARACSAHIBI = txtAracSahibi.Text;
                        aBilgi.ARACSAHIBITELEFON = decimal.Parse(mtbAracSahibiTel.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")); ; 



                        ent.SaveChanges();
                        MessageBox.Show("Güncelleme Başarılı");
                        dgvAraclar.DataSource = ent.ARACLAR.ToList();


                    }
                    else
                        MessageBox.Show("Güncellenecek kayda çift tıkla");
                }
                catch
                {
                    MessageBox.Show("Alanları kontrol ediniz");
                }
            }
        }
        
        
        private void aracsil()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                try
                {
                    if (dgvAraclar.SelectedRows.Count != 0)
                    {
                        int secilenAracId = Convert.ToInt32(dgvAraclar.CurrentRow.Cells[0].Value.ToString());
                        var aBilgi = ent.ARACLAR.Where(w => w.ARACID == secilenAracId).FirstOrDefault();

                        ent.ARACLAR.Remove(aBilgi);
                        ent.SaveChanges();
                        MessageBox.Show("Öğrenci Silindi");
                        dgvAraclar.DataSource = ent.MUSTERILER.ToList();

                        araclistele();

                    }
                    else
                        MessageBox.Show("Güncellenecek kayda çift tıkla");
                }
                catch
                {
                    MessageBox.Show("Alanları kontrol ediniz");
                }
            }
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            aracGuncelle();
        }

        private void dgvAraclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dgvAraclar.CurrentRow.Cells[1].Value.ToString();
            txtAracSahibi.Text = dgvAraclar.CurrentRow.Cells[2].Value.ToString();
            mtbAracSahibiTel.Text = dgvAraclar.CurrentRow.Cells[3].Value.ToString();
            rtbAcıklama.Text = dgvAraclar.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            aracListele ae = new aracListele();
            ae.ShowDialog();
        }

        
    }
}

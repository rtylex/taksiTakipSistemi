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
    public partial class surucuEkran : Form
    {
        public surucuEkran()
        {
            InitializeComponent();
        }

        private void surucuEkran_Load(object sender, EventArgs e)
        {
            suruculistele();
        }

        private void suruculistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var surucubilgi = from y in ent.SOFORLER select new { y.SOFORID,y.ADISOYADI, y.TELEFON,y.CALISMADURUMU};
                dgvSurucuListele.DataSource = surucubilgi.ToList();
                ent.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSoforKaydet_Click(object sender, EventArgs e)
        {
            surucukayit();
        }

        private void surucukayit()
        {

            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                try
                {
                    SOFORLER aa = new SOFORLER();
                    aa.ADISOYADI = txtSoforAdSoyad.Text;
                    aa.TELEFON = mtbSoforTel.Text;

                    if (rbMusait.Checked)
                    {
                        aa.CALISMADURUMU = rbMusait.Text;
                    }
                    else
                    {
                        aa.CALISMADURUMU = rbMesgul.Text;
                    }

                    ent.SOFORLER.Add(aa);
                    int result = ent.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("İŞLEM BAŞARI İLE GERÇEKLEŞTİ");
                    }
                    else
                    {
                        MessageBox.Show("Veritabanına ekleme işlemi başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }

                suruculistele();
            }

           
        }

        private void btnSurucuSil_Click(object sender, EventArgs e)
        {
            surucusil();
        }

        private void dgvSurucuListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoforAdSoyad.Text = dgvSurucuListele.CurrentRow.Cells[1].Value.ToString();
            mtbSoforTel.Text = dgvSurucuListele.CurrentRow.Cells[2].Value.ToString();
          


        }

        private void surucuguncelle()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {

                try
                {
                    if (dgvSurucuListele.SelectedRows.Count != 0)
                    {
                        int secilenSoforId = Convert.ToInt32(dgvSurucuListele.CurrentRow.Cells[0].Value.ToString());
                        var sBilgi = ent.SOFORLER.Where(w => w.SOFORID == secilenSoforId).FirstOrDefault();
                        sBilgi.ADISOYADI = txtSoforAdSoyad.Text;
                        sBilgi.TELEFON = mtbSoforTel.Text;
                        if (rbMusait.Checked)
                        {
                            sBilgi.CALISMADURUMU = rbMusait.Text;
                        }
                        else
                        {
                            sBilgi.CALISMADURUMU = rbMesgul.Text;
                        }


                        ent.SaveChanges();
                        MessageBox.Show("Güncelleme Başarılı");
                        dgvSurucuListele.DataSource = ent.SOFORLER.ToList();


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
        private void surucusil()
        {


            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {

                if (cbSil.Checked)
                {
                    try
                    {
                        if (dgvSurucuListele.SelectedRows.Count != 0)
                        {
                            int secilenSoforId = Convert.ToInt32(dgvSurucuListele.CurrentRow.Cells[0].Value.ToString());
                            var sBilgi = ent.SOFORLER.Where(w => w.SOFORID == secilenSoforId).FirstOrDefault();

                            ent.SOFORLER.Remove(sBilgi);
                            ent.SaveChanges();
                            MessageBox.Show("Sürücü Silindi");
                            dgvSurucuListele.DataSource = ent.MUSTERILER.ToList();

                            suruculistele();

                        }
                        else
                            MessageBox.Show("Güncellenecek kayda çift tıkla");
                    }
                    catch
                    {
                        MessageBox.Show("Alanları kontrol ediniz");
                    }
                }
                else
                {
                    MessageBox.Show("Tekrar seçin");
                }
                //try
                //{
                //    if (dgvSurucuListele.SelectedRows.Count != 0)
                //    {
                //        int secilenSoforId = Convert.ToInt32(dgvSurucuListele.CurrentRow.Cells[0].Value.ToString());
                //        var sBilgi = ent.SOFORLER.Where(w => w.SOFORID == secilenSoforId).FirstOrDefault();

                //        ent.SOFORLER.Remove(sBilgi);
                //        ent.SaveChanges();
                //        MessageBox.Show("Öğrenci Silindi");
                //        dgvSurucuListele.DataSource = ent.MUSTERILER.ToList();

                //        suruculistele();

                //    }
                //    else
                //        MessageBox.Show("Güncellenecek kayda çift tıkla");
                //}
                //catch
                //{
                //    MessageBox.Show("Alanları kontrol ediniz");
                //}
            }
        }
        private void btnSurucuGuncelle_Click(object sender, EventArgs e)
        {
            surucuguncelle();
            suruculistele();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbMusait_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

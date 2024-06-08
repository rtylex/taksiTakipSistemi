using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksiProjectNew
{
    public partial class musteriEkran : Form
    {
        public musteriEkran()
        {
            InitializeComponent();
        }

       

        private void musteriEkran_Load(object sender, EventArgs e)
        {
            musterilistele();
            musteribilgileri();
        }

        private void musterilistele()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                dgvMusteriListele.DataSource = ent.MUSTERILER.ToList();
                ent.SaveChanges();
            }
        }

       

        public void dgvMusteriListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dgvMusteriListele.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = dgvMusteriListele.CurrentRow.Cells[2].Value.ToString();
            rtbAdresTarif.Text = dgvMusteriListele.CurrentRow.Cells[3].Value.ToString();
            mtbTelefon.Text = dgvMusteriListele.CurrentRow.Cells[4].Value.ToString();
        }

        public void musterikayit()
        {

            if (String.IsNullOrEmpty(txtAdSoyad.Text) || String.IsNullOrEmpty(txtAdres.Text) ||
         String.IsNullOrEmpty(rtbAdresTarif.Text) || String.IsNullOrEmpty(mtbTelefon.Text))
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.");
                return;
            }

            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                // Telefon numarasına göre kontrol
                var numarakontrol = (from c in ent.MUSTERILER
                                      where c.TELEFON == mtbTelefon.Text
                                      select c).Any();

                if (numarakontrol)
                {
                    MessageBox.Show("Bu telefon numarasıyla kayıtlı bir müşteri zaten var.");
                }
                else
                {
                    // Yeni müşteri ekleme
                    MUSTERILER mekle = new MUSTERILER();
                    mekle.ADISOYADI = txtAdSoyad.Text;
                    mekle.ADRES = txtAdres.Text;
                    mekle.ADRESTARİF = rtbAdresTarif.Text;
                    mekle.TELEFON = mtbTelefon.Text;

                    ent.MUSTERILER.Add(mekle);
                    ent.SaveChanges();
                    MessageBox.Show("KULLANICI EKLENDİ");
                }
            }


        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            musterikayit();
            musterilistele();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            musteriguncelle();
        }


        private void musteriguncelle()
        {

            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                
                try
                {
                    if (dgvMusteriListele.SelectedRows.Count != 0)
                    {
                        int secilenMusteriId = Convert.ToInt32(dgvMusteriListele.CurrentRow.Cells[0].Value.ToString());
                        var mBilgi = ent.MUSTERILER.Where(w => w.MUSTERIID == secilenMusteriId).FirstOrDefault();
                        mBilgi.ADISOYADI = txtAdSoyad.Text;
                        mBilgi.ADRES = txtAdres.Text;
                        mBilgi.ADRESTARİF = rtbAdresTarif.Text;
                        mBilgi.TELEFON = mtbTelefon.Text;

                        ent.SaveChanges();
                        MessageBox.Show("Güncelleme Başarılı");
                        dgvMusteriListele.DataSource = ent.MUSTERILER.ToList();


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


        private void musteriSil()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                try
                {
                    if (dgvMusteriListele.SelectedRows.Count != 0)
                    {
                        int secilenMusteriId = Convert.ToInt32(dgvMusteriListele.CurrentRow.Cells[0].Value.ToString());
                        var mBilgi = ent.MUSTERILER.Where(w => w.MUSTERIID == secilenMusteriId).FirstOrDefault();
                        
                        ent.MUSTERILER.Remove(mBilgi);
                        ent.SaveChanges();
                        MessageBox.Show("Müşteri Silindi");
                        dgvMusteriListele.DataSource= ent.MUSTERILER.ToList();

                        musterilistele();

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
        private void musteribilgileri()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var musteriler = from m in ent.MUSTERILER select new {m.MUSTERIID,m.ADISOYADI, m.ADRES,m.ADRESTARİF,m.TELEFON};
                dgvMusteriListele.DataSource = musteriler.ToList(); 
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            musteriSil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriprofil mp = new musteriprofil();
            mp.ShowDialog();
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            MusteriAra();
        }

        private void MusteriAra()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                
                var musteriArama = (from v in ent.MUSTERILER where v.TELEFON == txtMusteriTelefonArama.Text select v).ToList();

                if (musteriArama.Count > 0)
                {
                    MessageBox.Show("Aramada " + musteriArama.Count + " müşteri bulundu.");
                    dgvMusteriListele.DataSource = musteriArama;
                }
            }
        }
    }
}

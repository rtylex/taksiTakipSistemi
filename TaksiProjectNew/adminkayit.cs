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
    public partial class adminkayit : Form
    {
        public adminkayit()
        {
            InitializeComponent();
        }

        private void btnAdminKayit_Click(object sender, EventArgs e)
        {
            adminkayitet();
        }

        private void adminkayitet()
        {
            if (cbKvkkOnay.Checked)
            {
                using (TaksiTakipEntities ent = new TaksiTakipEntities())
                {
                    ADMIN adminekle = new ADMIN();
                    adminekle.EPOSTA = txtAdminKayitEposta.Text;
                    adminekle.SIFRE = txtAdminKayitSifre.Text;

                    ent.ADMIN.Add(adminekle);
                    ent.SaveChanges();
                    MessageBox.Show("KAYIT BAŞARILI");
                }
            }
            else
            {
                MessageBox.Show("kvkk metnini onaylayınız");
            }


        }

        private void adminkayit_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kvkk.gov.tr/yayinlar/cerezlere_dair_aydinlatma_metni.pdf");
        }
    }
}

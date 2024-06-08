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
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        private void admingiris_Load(object sender, EventArgs e)
        {

        }

        private void girisadmin()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var admin = (from ae in ent.ADMIN
                                 where ae.EPOSTA == txtAdminGirisEposta.Text &&
                                 ae.SIFRE == txtAdminGirisSifre.Text
                                 select ae).ToList();

                if (String.IsNullOrEmpty(txtAdminGirisEposta.Text) && String.IsNullOrEmpty(txtAdminGirisSifre.Text))
                {
                    MessageBox.Show("Alanlar Boş geçilemez.");
                    return;
                }

                if (admin.Count > 0)

                {
                    Form1 fa = new Form1();
                    fa.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("E-posta ve şifre uyuşmuyor");
                }
            }
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            girisadmin();

        }
    }
}

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
    public partial class musteriprofil : Form
    {
        public musteriprofil()
        {
            InitializeComponent();
        }

        private void musteriprofil_Load(object sender, EventArgs e)
        {
            listeleme();    
        }

        private void listeleme()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                var musteribilgi = from y in ent.MUSTERILER select new {y.MUSTERIID,y.ADISOYADI, y.ADRES, y.ADRESTARİF, y.TELEFON };
                dataGridView1.DataSource = musteribilgi.ToList();
                ent.SaveChanges();
            }
        }

        private void verigetir()
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
              int deger = Convert.ToInt32(txtMusteriBilgi.Text);
              var customer =  ent.MUSTERILER.FirstOrDefault(c => c.MUSTERIID == deger);

                if (customer!= null)
                {
                    label5.Text = customer.ADISOYADI;
                    label6.Text = customer.ADRES;
                    label7.Text = customer.ADRESTARİF;
                    label8.Text = customer.TELEFON;
                }
            }
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            verigetir();
        }

    }
}

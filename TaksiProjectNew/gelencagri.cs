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
    public partial class gelencagri : Form
    {
        public gelencagri()
        {
            InitializeComponent();
        }

        private void gelencagri_Load(object sender, EventArgs e)
        {
            tumcagrilistele();
            
        }

      

        private void tumcagrilistele()
        {
           
                using (TaksiTakipEntities ent = new TaksiTakipEntities())
                {
                    var cagrilar = from m in ent.CAGRILAR select new { m.TARİHSAAT, m.MUSTERID, m.ARACID, m.SOFORID,m.NOT };
                    dataGridView1.DataSource = cagrilar.ToList();
                }


            

        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            using (TaksiTakipEntities ent = new TaksiTakipEntities())
            {
                if (checkBox1.Checked)
                {
                    var veriler = ent.CAGRILAR.ToList();
                    ent.CAGRILAR.RemoveRange(veriler);
                    ent.SaveChanges();
                    tumcagrilistele();
                }
               

            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            musteriEkran me = new musteriEkran();
            me.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracEkran ae= new aracEkran();  
            ae.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            surucuEkran se = new surucuEkran();
            se.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cagriyap cp = new cagriyap();
            cp.ShowDialog();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

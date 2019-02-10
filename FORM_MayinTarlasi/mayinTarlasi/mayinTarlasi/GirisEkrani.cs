using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayinTarlasi
{
    public partial class GirisEkrani : Form
    {
        public static int zorluk = 150;
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (rdbKolay.Checked)
                zorluk = 25;
            else if (rdbOrta.Checked)
                zorluk = 50;
            else
                zorluk = 100;

            Form1 frm = new Form1();
            this.Visible = false;
            frm.Show();
        }
    }
}

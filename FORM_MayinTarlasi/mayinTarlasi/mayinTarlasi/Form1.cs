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
    public partial class Form1 : Form
    {

        //public class MayinDegerler
        //{
        //    public Image Resim { get; set; };
        //    public int MayinDurum { get; set; };
        //}

        public int PUAN = 0;
        public int ZORLUK = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKalanMayin.Text = GirisEkrani.zorluk.ToString();
            Random rnd = new Random();
            for (int i = 0; i < 400; i++)
            {
                Button btn = new Button();
                btn.Name = ""+ i;
                btn.Margin = new System.Windows.Forms.Padding(0,0,0,0);
                btn.Tag = 0;
                btn.Width = 20;
                btn.Height = 20;
                btn.Click += Btn_Click;
                btn.MouseDown += Btn_MouseDown;
                btn.MouseUp += Btn_MouseUp;
                flwMayin.Controls.Add(btn);
            }

            for (int i = 0; i < GirisEkrani.zorluk; i++)
            {
                int randomYeri = rnd.Next(0, 401);
                    foreach (Control item in flwMayin.Controls)
                    {
                        if (item is Button)
                        {
                            Button flwBtn = item as Button;         // CAST ETTIK (BASKA BIR YOLLA !)
                            if (Convert.ToInt32(flwBtn.Name) == randomYeri)
                            {
                                flwBtn.Tag = 1;
                            }
                        }
                    }
            }
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            pctSurat.Image = ımageIcons.Images[2];
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            pctSurat.Image = ımageIcons.Images[4];
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            int mayinDurum = (int)newButton.Tag;

            if (mayinDurum == 1)
            {
                foreach (Control item in flwMayin.Controls)
                {
                    if (item is Button)
                    {
                        Button flwBtn = item as Button;         // CAST ETTIK (BASKA BIR YOLLA !)
                        flwBtn.BackgroundImageLayout = ImageLayout.Stretch;
                        if (Convert.ToInt32(flwBtn.Tag)== 1)
                        {
                            flwBtn.BackgroundImage = ımageIcons.Images[3];
                            flwBtn.BackColor = Color.Red;
                        }
                    }
                }
                pctSurat.Image = ımageIcons.Images[0];
                DialogResult yanit = MessageBox.Show(string.Format("Kaybettiniz, puanınız: {0}\nDevam Etmek İster misiniz?", PUAN), "" +
                    "OYUN SONLANDI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == yanit)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                newButton.BackgroundImage = ımageIcons.Images[2];
                if(newButton.BackColor!=Color.Blue)
                    PUAN += 100;
                lblPuan.Text = PUAN.ToString();

                newButton.BackColor = Color.Blue;
            }
        }
    }
}

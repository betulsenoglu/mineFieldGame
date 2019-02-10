namespace mayinTarlasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flwMayin = new System.Windows.Forms.FlowLayoutPanel();
            this.pctSurat = new System.Windows.Forms.PictureBox();
            this.ımageIcons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanMayin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctSurat)).BeginInit();
            this.SuspendLayout();
            // 
            // flwMayin
            // 
            this.flwMayin.Location = new System.Drawing.Point(4, 81);
            this.flwMayin.Name = "flwMayin";
            this.flwMayin.Size = new System.Drawing.Size(404, 409);
            this.flwMayin.TabIndex = 0;
            // 
            // pctSurat
            // 
            this.pctSurat.Image = ((System.Drawing.Image)(resources.GetObject("pctSurat.Image")));
            this.pctSurat.Location = new System.Drawing.Point(186, 22);
            this.pctSurat.Name = "pctSurat";
            this.pctSurat.Size = new System.Drawing.Size(40, 40);
            this.pctSurat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSurat.TabIndex = 1;
            this.pctSurat.TabStop = false;
            // 
            // ımageIcons
            // 
            this.ımageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageIcons.ImageStream")));
            this.ımageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageIcons.Images.SetKeyName(0, "dead.png");
            this.ımageIcons.Images.SetKeyName(1, "happy.png");
            this.ımageIcons.Images.SetKeyName(2, "happy2.png");
            this.ımageIcons.Images.SetKeyName(3, "mine.png");
            this.ımageIcons.Images.SetKeyName(4, "nervous.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(54, 13);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(13, 13);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Mayın:";
            // 
            // lblKalanMayin
            // 
            this.lblKalanMayin.AutoSize = true;
            this.lblKalanMayin.Location = new System.Drawing.Point(372, 13);
            this.lblKalanMayin.Name = "lblKalanMayin";
            this.lblKalanMayin.Size = new System.Drawing.Size(13, 13);
            this.lblKalanMayin.TabIndex = 5;
            this.lblKalanMayin.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 491);
            this.Controls.Add(this.lblKalanMayin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctSurat);
            this.Controls.Add(this.flwMayin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayin Tarlasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSurat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwMayin;
        private System.Windows.Forms.PictureBox pctSurat;
        private System.Windows.Forms.ImageList ımageIcons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanMayin;
    }
}


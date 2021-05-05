using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Flappy_Bird._1._0._0
{
    public partial class Ana_Sayfa : Form
    {


        public Ana_Sayfa()
        {
            InitializeComponent();

        }

        void PictureBox()
        {
            PictureBox pcb = new PictureBox();
            this.Controls.Add(pcb);
            pcb.Image = global::Flappy_Bird._1._0._0.Properties.Resources.pngtree_user_login_or_authenticate_icon_on_gray_background_flat_icon_ve_png_image_1786166;
            pcb.Location = new System.Drawing.Point(88, 12);
            pcb.Name = "pictureBox1";
            pcb.Size = new System.Drawing.Size(302, 187);
            pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcb.TabIndex = 0;
            pcb.TabStop = false;
        }

        void LabelLogin()
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.Location = new System.Drawing.Point(146, 202);
            lbl.Name = "label1";
            lbl.Size = new System.Drawing.Size(192, 44);
            lbl.TabIndex = 1;
            lbl.Text = "Login Your Account";
        }

        void LinkLabelŞifre()
        {
            LinkLabel link = new LinkLabel();
            Controls.Add(link);
            link.AutoSize = true;
            link.Location = new System.Drawing.Point(50, 506);
            link.Name = "linkLabel1";
            link.Size = new System.Drawing.Size(156, 25);
            link.TabIndex = 0;
            link.TabStop = true;
            link.Text = "Şifremi Unutdum";

            link.Click += Link_Click;
        }

        void LinkLabelUyeOl()
        {
            LinkLabel link = new LinkLabel();
            Controls.Add(link);
            link.AutoSize = true;
            link.Location = new System.Drawing.Point(400, 506);
            link.Name = "linkLabel2";
            link.Size = new System.Drawing.Size(156, 25);
            link.TabIndex = 0;
            link.TabStop = true;
            link.Text = "Üye Ol";

            link.Click += Link_Click1;
        }

        void LabelKullanıcıAd()
        {
            Label lbl = new Label();
            Controls.Add(lbl);
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(21, 263);
            lbl.Name = "label3";
            lbl.Size = new System.Drawing.Size(119, 25);
            lbl.TabIndex = 2;
            lbl.Text = "Kullanıcı Adı";
        }

        TextBox txtKullanıcıAd = new TextBox();
        void TextBoxKullanıcıAd()
        {
            this.Controls.Add(txtKullanıcıAd);
            txtKullanıcıAd.Location = new System.Drawing.Point(26, 307);
            txtKullanıcıAd.Name = "txtKullanıcıAd";
            txtKullanıcıAd.Size = new System.Drawing.Size(457, 30);
            txtKullanıcıAd.TabIndex = 3;
        }

        void LabelSifre()
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(21, 354);
            lbl.Name = "label2";
            lbl.Size = new System.Drawing.Size(52, 25);
            lbl.TabIndex = 2;
            lbl.Text = "Şifre";
        }

        TextBox txtSifre = new TextBox();
        void TextBoxSifre()
        {
            this.Controls.Add(txtSifre);
            txtSifre.Location = new System.Drawing.Point(26, 396);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(457, 30);
            txtSifre.PasswordChar = '*';
            txtSifre.TabIndex = 3;
        }

        Button btn = new Button();
        void ButtonLogin()
        {

            this.Controls.Add(btn);
            btn.BackColor = System.Drawing.Color.ForestGreen;
            btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn.Location = new System.Drawing.Point(26, 457);
            btn.Name = "btnLogin";
            btn.Size = new System.Drawing.Size(457, 49);
            btn.TabIndex = 4;
            btn.Text = "Login";
            btn.UseVisualStyleBackColor = false;

            btn.Click += Btn_Click;
        }


        private void Link_Click1(object sender, EventArgs e)
        {
            Kullanıcı_Formu kullanıcı_Formu = new Kullanıcı_Formu();
            kullanıcı_Formu.Show();
            this.Hide();
        }

        Flappy_BirdEntities4 db = new Flappy_BirdEntities4();
        private void Btn_Click(object sender, EventArgs e)
        {
            #region TextDosya
            //string sifre = "";
            //if (!string.IsNullOrEmpty(txtKullanıcıAd.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            //{
            //    string dosyaOku = (Environment.CurrentDirectory + @"\txt.text");
            //    string[] satirlar = System.IO.File.ReadAllLines(dosyaOku, Encoding.GetEncoding("windows-1254"));

            //    for (int i = 0; i < satirlar.Length; i++)
            //    {
            //        if (satirlar[i] == txtKullanıcıAd.Text)
            //        {
            //            sifre += satirlar[i + 1];
            //            if (sifre == txtSifre.Text)
            //            {
            //                Start_Game start = new Start_Game();
            //                start.Show();
            //                this.Hide();
            //            }
            //            else if (sifre == txtKullanıcıAd.Text)
            //            {
            //                MessageBox.Show("Bilgilerinizi Dogru Giriniz!...");
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bilgileri Giriniz...");
            //}
            #endregion

            kullanıcı(txtKullanıcıAd, txtSifre);


        }


        private void Link_Click(object sender, EventArgs e)
        {
            Şifre_Yenileme sifre = new Şifre_Yenileme();
            sifre.Show();
            this.Hide();
        }

        private void Ana_Sayfa_Load_1(object sender, EventArgs e)
        {
            PictureBox();
            LabelLogin();
            LabelKullanıcıAd();
            TextBoxKullanıcıAd();
            LabelSifre();
            TextBoxSifre();
            ButtonLogin();
            LinkLabelŞifre();
            LinkLabelUyeOl();

        }


        SqlConnection con = new SqlConnection("Server = DESKTOP-NTP7NSG; Database=Flappy_Bird;Trusted_Connection=True;");
        SqlCommand komut;
        SqlDataReader read;

        public  SqlDataReader kullanıcı(TextBox kullanıcıAdı, TextBox sifre)
        {
            con.Open();
            komut = new SqlCommand();
            komut.Connection = con;
            komut.CommandText = "select * from dbo.Member where UserName = '" + txtKullanıcıAd.Text + "'";
            read = komut.ExecuteReader();

            if (read.Read() == true)
            {
                if (txtSifre.Text == read["Password"].ToString().Trim())
                {
                    MessageBox.Show("Giriş Başarılı");
                    Start_Game start = new Start_Game();
                    start.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz!...", "Hata Mesajı");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz!...", "Hata Mesajı");
            }
            con.Close();
            return read;
        } 
    }
}

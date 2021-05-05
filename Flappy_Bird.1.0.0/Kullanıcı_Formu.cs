using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird._1._0._0
{
    public partial class Kullanıcı_Formu : Form
    {


        public Kullanıcı_Formu()
        {
            InitializeComponent();
        }

        void LabelAD()
        {
            Label lbl = new Label();
            this.Controls.Add(lbl);
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(-1, 9);
            lbl.Name = "lblAd";
            lbl.Size = new System.Drawing.Size(99, 25);
            lbl.TabIndex = 0;
            lbl.Text = "Ad Soyad";
            lbl.BackColor = System.Drawing.Color.Aqua;
            lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
        void LabelKullanıcıAd()
        {
            Label lbl1 = new Label();
            this.Controls.Add(lbl1);
            lbl1.AutoSize = true;
            lbl1.Location = new System.Drawing.Point(-1, 70);
            lbl1.Name = "lblKullanıcıAdı";
            lbl1.Size = new System.Drawing.Size(119, 25);
            lbl1.TabIndex = 7;
            lbl1.Text = "Kullanıcı Adı";
            lbl1.BackColor = System.Drawing.Color.Aqua;
            lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
        void Sifre()
        {
            Label lblSifre = new Label();
            this.Controls.Add(lblSifre);
            lblSifre.AutoSize = true;
            lblSifre.Location = new System.Drawing.Point(-1, 113);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(52, 25);
            lblSifre.TabIndex = 6;
            lblSifre.Text = "Şifre";
            lblSifre.BackColor = System.Drawing.Color.Aqua;
            lblSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
        void SifreTekrarı()
        {
            Label lblSifreTekrarı = new Label();
            Controls.Add(lblSifreTekrarı);
            lblSifreTekrarı.AutoSize = true;
            lblSifreTekrarı.Location = new System.Drawing.Point(-1, 164);
            lblSifreTekrarı.Name = "lblSifreTekrarı";
            lblSifreTekrarı.Size = new System.Drawing.Size(118, 25);
            lblSifreTekrarı.TabIndex = 22;
            lblSifreTekrarı.Text = "Şifre Tekrarı";
            lblSifreTekrarı.BackColor = System.Drawing.Color.Aqua;
            lblSifreTekrarı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
        void Soru()
        {
            Label lblSoru = new Label();
            Controls.Add(lblSoru);
            lblSoru.AutoSize = true;
            lblSoru.Location = new System.Drawing.Point(-1, 214);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new System.Drawing.Size(54, 25);
            lblSoru.TabIndex = 23;
            lblSoru.Text = "Soru";
            lblSoru.BackColor = System.Drawing.Color.Aqua;
            lblSoru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }
        void Cevap()
        {
            Label lblCevap = new Label();
            Controls.Add(lblCevap);
            lblCevap.AutoSize = true;
            lblCevap.Location = new System.Drawing.Point(1, 264);
            lblCevap.Name = "lblCevap";
            lblCevap.Size = new System.Drawing.Size(70, 25);
            lblCevap.TabIndex = 24;
            lblCevap.Text = "Cevap";
            lblCevap.BackColor = System.Drawing.Color.Aqua;
            lblCevap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        TextBox txtAdSoyad = new TextBox();
        public void TextBoxAdSoyad()
        {
            this.Controls.Add(txtAdSoyad);
            txtAdSoyad.Location = new System.Drawing.Point(196, 7);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new System.Drawing.Size(273, 30);
            txtAdSoyad.TabIndex = 43;
        }

        TextBox txtkullanıcıAdı = new TextBox();
        void TxtKullanıcıAdı()
        {
            this.Controls.Add(txtkullanıcıAdı);
            txtkullanıcıAdı.Location = new System.Drawing.Point(196, 56);
            txtkullanıcıAdı.Name = "txtKullanıcıAd";
            txtkullanıcıAdı.Size = new System.Drawing.Size(273, 30);
            txtkullanıcıAdı.TabIndex = 42;
        }

        TextBox txtsifre = new TextBox();
        void TxtSifre()
        {
            this.Controls.Add(txtsifre);
            txtsifre.Location = new System.Drawing.Point(196, 114);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new System.Drawing.Size(273, 30);
            txtsifre.PasswordChar = '*';
            txtsifre.TabIndex = 41;
        }

        TextBox txtsifretekrarı = new TextBox();
        void TxtSifreTekrarı()
        {
            this.Controls.Add(txtsifretekrarı);
            txtsifretekrarı.Location = new System.Drawing.Point(196, 159);
            txtsifretekrarı.Name = "sifreTekrarı";
            txtsifretekrarı.Size = new System.Drawing.Size(273, 30);
            txtsifretekrarı.PasswordChar = '*';
            txtsifretekrarı.TabIndex = 40;
        }

        TextBox txtSoru = new TextBox();
        void TxtSoru()
        {
            this.Controls.Add(txtSoru);
            txtSoru.Location = new System.Drawing.Point(198, 215);
            txtSoru.Name = "txtSoru";
            txtSoru.Size = new System.Drawing.Size(273, 30);
            txtSoru.TabIndex = 39;
        }

        TextBox txtCevap = new TextBox();
        void TxtCevap()
        {
            this.Controls.Add(txtCevap);
            txtCevap.Location = new System.Drawing.Point(198, 260);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new System.Drawing.Size(273, 30);
            txtCevap.TabIndex = 38;
        }

        void ButtonKayıt()
        {
            Button btnKayıt = new Button();
            Controls.Add(btnKayıt);
            btnKayıt.Location = new System.Drawing.Point(198, 301);
            btnKayıt.Name = "btnKayıt";
            btnKayıt.Size = new System.Drawing.Size(273, 57);
            btnKayıt.TabIndex = 54;
            btnKayıt.Text = "KAYIT OL";
            btnKayıt.UseVisualStyleBackColor = true;
            btnKayıt.BackColor = System.Drawing.Color.Aqua;
            btnKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            btnKayıt.Click += BtnKayıt_Click;
        }

        void PictureBox()
        {
            PictureBox pcb = new PictureBox();
            this.Controls.Add(pcb);
            pcb.Image = global::Flappy_Bird._1._0._0.Properties.Resources._01EkIOfisgxkfodZ4JmTIXa_1_1569489280_fit_lim___Kopya;
            pcb.Location = new System.Drawing.Point(1, 1);
            pcb.Name = "pictureBox1";
            pcb.Size = new System.Drawing.Size(583, 468);
            pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcb.TabIndex = 0;
            pcb.TabStop = false;
        }

        Flappy_BirdEntities4 db = new Flappy_BirdEntities4();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            #region TextDosya
            //string[] satırlar = new string[] { txtAdSoyad.Text, txtkullanıcıAdı.Text, txtsifre.Text, txtSoru.Text, txtCevap.Text };
            //File.AppendAllLines(Environment.CurrentDirectory + @"\txt.text", satırlar);

            //if (txtkullanıcıAdı.Text.Length > 0 && txtsifre.Text.Length > 0 && txtsifretekrarı.Text.Length > 0 && txtSoru.Text.Length > 0 && txtCevap.Text.Length > 0)
            //{
            //    if (txtsifre.Text == txtsifretekrarı.Text)
            //    {
            //        Ana_Sayfa f = new Ana_Sayfa();
            //        f.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Şifrenizi kontrol ediniz", "Hata Mesajı");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Tüm kolonnarı doldurunuz!...", "Hata Mesajı");
            //}
            #endregion


            if (!string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtkullanıcıAdı.Text) && !string.IsNullOrEmpty(txtsifre.Text) && !string.IsNullOrEmpty(txtsifretekrarı.Text) && !string.IsNullOrEmpty(txtSoru.Text) && !string.IsNullOrEmpty(txtCevap.Text))
            {
                Member member = new Member();
                member.NameLastName = txtAdSoyad.Text;
                member.UserName = txtkullanıcıAdı.Text;
                member.Password = txtsifre.Text;
                member.PasswordRepeat = txtsifretekrarı.Text;
                member.Question = txtSoru.Text;
                member.Answer = txtCevap.Text;
                db.Member.Add(member);
                db.SaveChanges();

                if (txtsifre.Text == txtsifretekrarı.Text)
                {
                    Ana_Sayfa ana = new Ana_Sayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz!...", "Hata Mesajı...");
                }
            }
            else
            {
                MessageBox.Show("Tüm Kolonnarı Doldurunuz!...", "Hata Mesajı...");
            }
        }

        private void Kullanıcı_Formu_Load(object sender, EventArgs e)
        {
            LabelAD();
            LabelKullanıcıAd();
            Sifre();
            SifreTekrarı();
            Soru();
            Cevap();
            TextBoxAdSoyad();
            TxtKullanıcıAdı();
            TxtSifre();
            TxtSifreTekrarı();
            TxtSoru();
            TxtCevap();
            ButtonKayıt();
            PictureBox();
        }
    }
}

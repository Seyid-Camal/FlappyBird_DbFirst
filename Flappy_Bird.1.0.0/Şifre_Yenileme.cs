using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flappy_Bird._1._0._0
{
    public partial class Şifre_Yenileme : Form
    {
        public Şifre_Yenileme()
        {
            InitializeComponent();
        }

        void LabelKullanıcıAdı()
        {
            Label lblKullanıcıİsmi = new Label();
            Controls.Add(lblKullanıcıİsmi);
            lblKullanıcıİsmi.AutoSize = true;
            lblKullanıcıİsmi.Location = new System.Drawing.Point(12, 350);
            lblKullanıcıİsmi.Name = "lblKullanıcıİsmi";
            lblKullanıcıİsmi.Size = new System.Drawing.Size(119, 25);
            lblKullanıcıİsmi.TabIndex = 1;
            lblKullanıcıİsmi.Text = "Kullanıcı Adı";
        }

        void LabelSifre()
        {
            Label lblSifre = new Label();
            this.Controls.Add(lblSifre);
            lblSifre.AutoSize = true;
            lblSifre.Location = new System.Drawing.Point(12, 426);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(96, 25);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Yeni Şifre";
        }

        void LabelSifreTekrarı()
        {
            Label lblSifreTekrarı = new Label();
            this.Controls.Add(lblSifreTekrarı);
            lblSifreTekrarı.AutoSize = true;
            lblSifreTekrarı.Location = new System.Drawing.Point(12, 495);
            lblSifreTekrarı.Name = "lblSifreTekrarı";
            lblSifreTekrarı.Size = new System.Drawing.Size(118, 25);
            lblSifreTekrarı.TabIndex = 1;
            lblSifreTekrarı.Text = "Şifre Tekrarı";
        }

        void PictureBox()
        {
            PictureBox pcb = new PictureBox();
            this.Controls.Add(pcb);
            pcb.Image = global::Flappy_Bird._1._0._0.Properties.Resources.unnamed1;
            pcb.Location = new System.Drawing.Point(123, 12);
            pcb.Name = "pictureBox1";
            pcb.Size = new System.Drawing.Size(405, 275);
            pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcb.TabIndex = 0;
            pcb.TabStop = false;
        }


        TextBox txtKullanıcıAd = new TextBox();
        void TextBoxKullanıcıAdı()
        {
            this.Controls.Add(txtKullanıcıAd);
            txtKullanıcıAd.Location = new System.Drawing.Point(178, 347);
            txtKullanıcıAd.Name = "txtKullanıcıAd";
            txtKullanıcıAd.Size = new System.Drawing.Size(350, 30);
            txtKullanıcıAd.TabIndex = 2;
        }


        TextBox txtSifre = new TextBox();
        void TextBoxYeniSifre()
        {
            this.Controls.Add(txtSifre);
            txtSifre.Location = new System.Drawing.Point(178, 421);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new System.Drawing.Size(350, 30);
            txtSifre.TabIndex = 2;
        }


        TextBox txtSifreTekrarı = new TextBox();
        void TextBoxSifreTekrarı()
        {
            this.Controls.Add(txtSifreTekrarı);
            txtSifreTekrarı.Location = new System.Drawing.Point(178, 490);
            txtSifreTekrarı.Name = "txtSifreTekrarı";
            txtSifreTekrarı.PasswordChar = '*';
            txtSifreTekrarı.Size = new System.Drawing.Size(350, 30);
            txtSifreTekrarı.TabIndex = 2;
        }

        void Button()
        {
            Button btnOnayla = new Button();
            this.Controls.Add(btnOnayla);
            btnOnayla.BackColor = System.Drawing.Color.Navy;
            btnOnayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOnayla.Location = new System.Drawing.Point(52, 556);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new System.Drawing.Size(571, 56);
            btnOnayla.TabIndex = 3;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;

            btnOnayla.Click += BtnOnayla_Click;
        }



        Flappy_BirdEntities4 db = new Flappy_BirdEntities4();
        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            #region Dosya Yaz
            //string yeniSifre = "";
            //if (!string.IsNullOrEmpty(txtKullanıcıAd.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(txtSifreTekrarı.Text) && txtSifre.Text == txtSifreTekrarı.Text)
            //{
            //    string dosyaOku = (Environment.CurrentDirectory + @"\txt.text");
            //    string[] satirlar = System.IO.File.ReadAllLines(dosyaOku, Encoding.GetEncoding("windows-1254"));

            //    for (int i = 0; i < satirlar.Length; i++)
            //    {
            //        if (satirlar[i] == txtKullanıcıAd.Text)
            //        {
            //            yeniSifre += satirlar[i + 1];
            //            if (yeniSifre != txtSifre.Text)
            //            {
            //                if (File.Exists(Environment.CurrentDirectory + @"\txt.text"))
            //                {
            //                    File.Delete(Environment.CurrentDirectory + @"\txt.text");
            //                    string[] satırlar = new string[] { txtKullanıcıAd.Text, txtSifre.Text };
            //                    File.AppendAllLines(Environment.CurrentDirectory + @"\txt.text", satırlar);
            //                }
            //            }
            //        }
            //    }
            //    Ana_Sayfa ana_Sayfa = new Ana_Sayfa();
            //    ana_Sayfa.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Bilgileri Giriniz...");
            //} 
            #endregion
            SifreYenile(txtSifre,txtSifreTekrarı);
        }

        private void Şifre_Yenileme_Load(object sender, EventArgs e)
        {
            LabelKullanıcıAdı();
            LabelSifre();
            LabelSifreTekrarı();
            PictureBox();
            TextBoxKullanıcıAdı();
            TextBoxYeniSifre();
            TextBoxSifreTekrarı();
            Button();
        }


        SqlConnection con = new SqlConnection("Server = DESKTOP-NTP7NSG; Database=Flappy_Bird;Trusted_Connection=True;");
        SqlCommand komut;
        SqlDataReader read;

        public void SifreYenile(TextBox sifre,TextBox sifreTekrarı)
        {
            con.Open();
            komut = new SqlCommand("select * from dbo.Member where UserName = '" + txtKullanıcıAd.Text + "'", con);
            read = komut.ExecuteReader();

            if (!string.IsNullOrEmpty(txtKullanıcıAd.Text) && !string.IsNullOrEmpty(txtSifre.Text) && !string.IsNullOrEmpty(txtSifreTekrarı.Text))
            {
                if (txtSifre.Text == txtSifreTekrarı.Text)
                {
                    if (read.Read() == true)
                    {
                        read.Close();
                        SqlCommand guncelle = new SqlCommand("update Member set Password = '" + txtSifre.Text + "' where UserName= '" + txtKullanıcıAd.Text + "'", con);
                        guncelle.ExecuteNonQuery();
                        MessageBox.Show("Şifreniz Güncellendi...");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adınız Hatalı!...");
                    }

                    Ana_Sayfa ana = new Ana_Sayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz!...");
                }
            }
            else
            {
                MessageBox.Show("Kolonnarı Doldurunuz!...");
            }
            con.Close();
        }
    }
}

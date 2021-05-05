using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird._1._0._0
{
    public partial class Start_Game : Form
    {
        public Start_Game()
        {
            InitializeComponent();
        }
        Form frm = new Form();
        void Form()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(544, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Start_Game";
            this.Text = "Start_Game";
            this.Load += new System.EventHandler(this.Start_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        PictureBox pictureBox1 = new PictureBox();
        void PictureBox()
        {

            this.Controls.Add(pictureBox1);
            pictureBox1.Image = global::Flappy_Bird._1._0._0.Properties.Resources.kisspng_flappy_bird_sprite_clip_art_birds_cartoon_5b323968d63042_7481847415300181528773;
            pictureBox1.Location = new System.Drawing.Point(94, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(366, 293);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
        }

        Button button1 = new Button();
        void Button()
        {
            this.Controls.Add(button1);
            button1.BackColor = System.Drawing.Color.Aqua;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button1.ImageKey = "free-play-icon-25.jpg";
            button1.Location = new System.Drawing.Point(94, 397);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(366, 100);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Oyun_Paneli oyun = new Oyun_Paneli();
            oyun.Show();
            this.Hide();
        }

        private void Start_Game_Load(object sender, EventArgs e)
        {
            Form();
            PictureBox();
            Button();
        }
    }
}

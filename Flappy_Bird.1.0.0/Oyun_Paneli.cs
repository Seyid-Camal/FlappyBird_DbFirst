using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Flappy_Bird._1._0._0
{
    public partial class Oyun_Paneli : Form
    {

        SoundPlayer player = new SoundPlayer();
        public Oyun_Paneli()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pcbGameOver.Visible = false;
            pcbReplay.Visible = false;
        }

        void Form()
        {
            Form frm = new Form();
            //this.Controls.Add(frm);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Name = "Oyun_Paneli";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Oyun_Paneli_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Oyun_Paneli_KeyDown);
            this.ResumeLayout(false);
        }

        void PictureBoxYer()
        {
            PictureBox pcb = new PictureBox();
            Controls.Add(pcb);
            pcb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            pcb.Location = new System.Drawing.Point(-6, 537);
            pcb.Name = "pictureBox1";
            pcb.Size = new System.Drawing.Size(1369, 192);
            pcb.TabIndex = 0;
            pcb.TabStop = false;
        }

        PictureBox tr1 = new PictureBox();
        void PictureBoxTree1()
        {

            Controls.Add(tr1);
            tr1.Image = global::Flappy_Bird._1._0._0.Properties.Resources._5a1c619d035683_3892400515118094370137;
            tr1.Location = new System.Drawing.Point(68, 448);
            tr1.Name = "tr1";
            tr1.Size = new System.Drawing.Size(105, 92);
            tr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            tr1.TabIndex = 1;
            tr1.TabStop = false;
        }

        PictureBox tr2 = new PictureBox();
        void PictureBoxTree2()
        {

            this.Controls.Add(tr2);
            tr2.Image = global::Flappy_Bird._1._0._0.Properties.Resources._5a1c619d035683_3892400515118094370137;
            tr2.Location = new System.Drawing.Point(619, 448);
            tr2.Name = "tr2";
            tr2.Size = new System.Drawing.Size(105, 92);
            tr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            tr2.TabIndex = 1;
            tr2.TabStop = false;
        }

        PictureBox tr3 = new PictureBox();
        void PictureBoxtree3()
        {

            this.Controls.Add(tr3);
            tr3.Image = global::Flappy_Bird._1._0._0.Properties.Resources._5a1c619d035683_3892400515118094370137;
            tr3.Location = new System.Drawing.Point(1202, 448);
            tr3.Name = "tr3";
            tr3.Size = new System.Drawing.Size(105, 92);
            tr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            tr3.TabIndex = 1;
            tr3.TabStop = false;
        }

        PictureBox pipe1 = new PictureBox();
        void PictureBoxPipe1()
        {

            this.Controls.Add(pipe1);
            pipe1.BackColor = System.Drawing.Color.Black;
            pipe1.Location = new System.Drawing.Point(322, -3);
            pipe1.Name = "pipe1";
            pipe1.Size = new System.Drawing.Size(124, 206);
            pipe1.TabIndex = 2;
            pipe1.TabStop = false;
        }

        PictureBox pipe2 = new PictureBox();
        void PictureBoxPipe2()
        {

            this.Controls.Add(pipe2);
            pipe2.BackColor = System.Drawing.Color.Black;
            pipe2.Location = new System.Drawing.Point(944, -3);
            pipe2.Name = "pipe2";
            pipe2.Size = new System.Drawing.Size(124, 206);
            pipe2.TabIndex = 3;
            pipe2.TabStop = false;
        }

        PictureBox pipe3 = new PictureBox();
        void PictureBoxPipe3()
        {

            this.Controls.Add(pipe3);
            pipe3.BackColor = System.Drawing.Color.Black;
            pipe3.Location = new System.Drawing.Point(322, 389);
            pipe3.Name = "pipe3";
            pipe3.Size = new System.Drawing.Size(124, 322);
            pipe3.TabIndex = 2;
            pipe3.TabStop = false;
        }

        PictureBox pipe4 = new PictureBox();
        void PictureBoxPipe4()
        {

            this.Controls.Add(pipe4);
            pipe4.BackColor = System.Drawing.Color.Black;
            pipe4.Location = new System.Drawing.Point(944, 389);
            pipe4.Name = "pipe4";
            pipe4.Size = new System.Drawing.Size(124, 322);
            pipe4.TabIndex = 4;
            pipe4.TabStop = false;
        }

        PictureBox pcbBird = new PictureBox();
        void PictureBoxBird()
        {

            this.Controls.Add(pcbBird);
            pcbBird.Image = global::Flappy_Bird._1._0._0.Properties.Resources.kisspng_flappy_bird_sprite_clip_art_birds_cartoon_5b323968d63042_7481847415300181528773;
            pcbBird.Location = new System.Drawing.Point(34, 254);
            pcbBird.Name = "pcbBird";
            pcbBird.Size = new System.Drawing.Size(76, 50);
            pcbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcbBird.TabIndex = 5;
            pcbBird.TabStop = false;
        }

        PictureBox pcbGameOver = new PictureBox();
        void PictureBoxGameOver()
        {

            this.Controls.Add(pcbGameOver);
            pcbGameOver.Image = global::Flappy_Bird._1._0._0.Properties.Resources.kisspng_flappy_bird_clumsy_bird_video_game_game_over_hanuman_5ad3289f4467a9_0034722215237879352802;
            pcbGameOver.Location = new System.Drawing.Point(504, 66);
            pcbGameOver.Name = "pcbGameOver";
            pcbGameOver.Size = new System.Drawing.Size(372, 320);
            pcbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcbGameOver.TabIndex = 6;
            pcbGameOver.TabStop = false;
        }

        Label lblScore = new Label();
        void LabelScore()
        {

            this.Controls.Add(lblScore);
            lblScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblScore.Location = new System.Drawing.Point(12, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(100, 61);
            lblScore.TabIndex = 7;
            lblScore.Text = "0";
        }

        Timer timer1 = new Timer();
        void Timer()
        {

            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Tick += timer1_Tick;
        }

        Timer timer2 = new Timer();
        void Timer2()
        {

            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            timer2.Tick += timer2_Tick;
        }

        PictureBox pcbReplay = new PictureBox();
        void PictureBoxReplay()
        {
            pcbReplay.Image = global::Flappy_Bird._1._0._0.Properties.Resources._203_2036420_replay_png_page_replay_button_png_transparent_png;
            pcbReplay.Location = new System.Drawing.Point(440, 12);
            pcbReplay.Name = "pcbReplay";
            pcbReplay.Size = new System.Drawing.Size(569, 114);
            pcbReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcbReplay.TabIndex = 0;
            pcbReplay.TabStop = false;
            this.Controls.Add(pcbReplay);
            pcbReplay.Click += PcbReplay_Click;
        }

        private void PcbReplay_Click(object sender, EventArgs e)
        {
            Oyun_Paneli oyun = new Oyun_Paneli();
            oyun.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pcbBird.Top <= 522)

                pcbBird.Top += 2;
            score++;
            lblScore.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveTree(10);//Agacları Haraket etdirir
            MoveHurdle(5);// Boru Engelleri haraket etdirir
            GameOver();
        }

        private void Oyun_Paneli_Load(object sender, EventArgs e)
        {
            Form();
            PictureBoxYer();
            PictureBoxTree1();
            PictureBoxTree2();
            PictureBoxtree3();
            PictureBoxPipe1();
            PictureBoxPipe2();
            PictureBoxPipe3();
            PictureBoxPipe4();
            PictureBoxBird();
            PictureBoxGameOver();
            LabelScore();

            PictureBoxReplay();

            player.SoundLocation = "music.waw.wav";
            player.Play();
        }


        Random rnd = new Random();
        void MoveHurdle(int speed)// Engel Borular
        {
            if (pipe1.Left >= 0)
                pipe1.Left += -speed;
            else
                pipe1.Left = 1020;
            pipe1.Height = rnd.Next(200, 250);

            if (pipe2.Left >= 0)
                pipe2.Left += -speed;
            else
                pipe2.Left = 1020;
            pipe2.Height = rnd.Next(250, 300);

            if (pipe3.Left >= 0)
                pipe3.Left += -speed;
            else
                pipe3.Left = 1020;
            pipe3.Height = rnd.Next(260, 280);

            if (pipe4.Left >= 0)
                pipe4.Left += -speed;
            else
                pipe4.Left = 1020;
            pipe4.Height = rnd.Next(265, 280);
        }

        int score = 0;
        // int speed bizi agacın suratini belirler.
        void MoveTree(int speed) // Agacı Haraket etdirir
        {
            if (tr1.Left >= 0)
                tr1.Left += -speed;
            else
                tr1.Left = 1028;

            if (tr2.Left >= 0)
                tr2.Left += -speed;
            else
                tr2.Left = 1028;

            if (tr3.Left >= 0)
                tr3.Left += -speed;
            else
                tr3.Left = 1028;
        }


        void GameOver()
        {
            if (pcbBird.Bounds.IntersectsWith(pipe1.Bounds) || pcbBird.Bounds.IntersectsWith(pipe2.Bounds) || pcbBird.Bounds.IntersectsWith(pipe3.Bounds) || pcbBird.Bounds.IntersectsWith(pipe4.Bounds))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                pcbGameOver.Visible = true;
                pcbReplay.Visible = true;
            }
        }

        private void Oyun_Paneli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pcbBird.Top += -50;
            }

            if (timer2.Enabled == false)
            {
                Timer2();
                Timer();
            }
        }

    }
}

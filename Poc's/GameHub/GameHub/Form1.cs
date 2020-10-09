using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHub
{
    public partial class Form1 : Form
    {
        private const string nameInvaderLeft = "invaderLeft";
        private const string nameInvaderRight = "invaderRight";
        private const string nameBullet = "bullet";
        bool goleft;
        bool goright;
        int speed = 3;
        int score = 0;
        bool isPressed;
        int maxRows = 4;
        int totalEnemies;
        int rowEnemies = 10;
        int playerSpeed = 6;
        int x = 800;
        int y = 29;
        public Form1()
        {
            Alien alien = new Alien(5, "alien");
            Player player = new Player(10, "Player");
            for (int row = 0; row < maxRows; row++)
            {

                for (int aliens = 0; aliens < rowEnemies; aliens++)
                {
                    this.Controls.Add(alien.BuildFullPictureBox(x, y, row));
                    x -= 55;
                    totalEnemies++;

                }
                x = 800;
                y += 55;
            }
           // this.Controls.Add(player.BuildFullPictureBox(516, 540, 1));
            InitializeComponent();

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                MakeBullet();
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (isPressed)
            {
                isPressed = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // player movement:
            if (goleft)
            {
                if (player.Left > 0)
                {
                    player.Left -= playerSpeed;
                }
                else
                {
                    player.Left = 0;
                }
            }
            if (goright)
            {
                if (player.Left < ClientRectangle.Width - player.Size.Width)
                {
                    player.Left += playerSpeed;
                }
                else
                {
                    player.Left = ClientRectangle.Width - player.Size.Width;
                }
            }
            // invader movement:
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (x.Tag == nameInvaderLeft || x.Tag == nameInvaderRight))
                {
                    PictureBox a = (PictureBox)x;
                    if (a.Bounds.IntersectsWith(player.Bounds))
                    {
                        label1.Text = "Game Over";
                        GameOver();
                    }
                    if (a.Tag == nameInvaderLeft)
                    {
                        a.Left += speed;
                    }
                    if (a.Tag == nameInvaderRight)
                    {
                        a.Left -= speed;
                    }
                    if (a.Location.X > (ClientRectangle.Width - a.Size.Width))
                    {
                        foreach (Control allInvaderLeft in this.Controls)
                        {
                            if (allInvaderLeft is PictureBox && (allInvaderLeft.Tag == nameInvaderLeft || allInvaderLeft.Tag == nameInvaderRight))
                            {
                                allInvaderLeft.Top += allInvaderLeft.Height + 5;
                                allInvaderLeft.Tag = nameInvaderRight;
                            }
                        }
                    }
                    if (a.Left <= 0)
                    {
                        foreach (Control allInvadersRight in this.Controls)
                        {
                            if (allInvadersRight is PictureBox && (allInvadersRight.Tag == nameInvaderLeft || allInvadersRight.Tag == nameInvaderRight))
                            {
                                allInvadersRight.Top += allInvadersRight.Height + 5;
                                allInvadersRight.Tag = nameInvaderLeft;
                            }
                        }
                    }
                }
            }
            // bullet movement:
            foreach (Control shot in this.Controls)
            {
                if (shot is PictureBox && shot.Tag == nameBullet)
                {
                    shot.Top -= 20;
                    if (((PictureBox)shot).Top < 29)
                    {
                        this.Controls.Remove(shot);
                    }
                }
            }
            // bullet alien collision:
            foreach (Control invader in this.Controls)
            {
                foreach (Control bullets in this.Controls)
                {
                    if (invader is PictureBox && (invader.Tag == nameInvaderLeft || invader.Tag == nameInvaderRight))
                    {
                        if (bullets is PictureBox && bullets.Tag == nameBullet)
                        {
                            if (invader.Bounds.IntersectsWith(bullets.Bounds))
                            {
                                score++;
                                this.Controls.Remove(invader);
                                this.Controls.Remove(bullets);
                            }
                        }
                    }
                }
            }
            // updating label:
            label1.Text = "Score : " + score;
            if (score == totalEnemies)
            {
                label1.Text = "You Win!!!!";
                GameOver();
            }
        }
        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet1;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2;
            bullet.Top = player.Top - 20;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void GameOver()
        {
            SpawnResetButton();
            timer1.Stop();
        }

        private void SpawnResetButton()
        {
            Button resetButton = new Button();
            if (label1.Text == "Game Over")
            {
                resetButton.Text = "retry";
            }
            else
            {
                resetButton.Text = "continue";
            }
            resetButton.Width = 100;
            resetButton.Height = 75;
            resetButton.Location = new Point(130, 0);
            resetButton.Click += new EventHandler(resetButton_Click);
            Controls.Add(resetButton);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Button resetButton = sender as Button;
            y = 29;

            if (resetButton.Text == "retry")
            {
                totalEnemies = 0;
                label1.Text = "";
                score = 0;
                speed = 5;
                int invadercounter = 0;

                foreach (Control aliveInvaders in this.Controls)
                {
                    if (aliveInvaders is PictureBox && (aliveInvaders.Tag == nameInvaderLeft || aliveInvaders.Tag == nameInvaderRight))
                    {
                        invadercounter++;
                        this.Controls.Remove(aliveInvaders);
                    }
                }
            }
            else
            {
                x = 568;
                label1.Text = "Score: " + score;
                speed += 3;

                Alien alien = new Alien(5, "alien");
                for (int row = 0; row < maxRows; row++)
                {

                    for (int aliens = 0; aliens < rowEnemies; aliens++)
                    {
                        this.Controls.Add(alien.BuildFullPictureBox(x, y, row));
                        x -= 55;
                        totalEnemies++;

                    }
                    x = 568;
                    y += 55;
                }

                timer1.Start();
                resetButton.Dispose();
            }
        }

    }
}
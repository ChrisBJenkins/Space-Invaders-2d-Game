using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Space_Invaders
{
    public partial class Space_Invaders : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] enemiesMunition;
        int enemiesMunitionSpeed;

        PictureBox[] stars;
        Random rnd;
        int backgroundspeed;
        int playerspeed;

        PictureBox[] munitions;
        int MunitionSpeed;

        PictureBox[] enemies;
        int enemySpeed;

        int score;
        int level;
        int difficulty; // how many enemies can be shot
        bool pause;
        bool gameIsOver;

        public Space_Invaders()
        {
            InitializeComponent();
        }

        private void Space_Invaders_Load(object sender, EventArgs e)
        {
            stars = new PictureBox[15];
            munitions = new PictureBox[3];
            rnd = new Random();

            // Load Speeds
            backgroundspeed = 4;
            playerspeed = 4;
            MunitionSpeed = 20;
            enemySpeed = 4;
            enemiesMunitionSpeed = 4;

            // Create Level Variables
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 0;
            difficulty = 9;

            //Create wmp , Load Media
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            // Load All Songs
            gameMedia.URL = "songs\\GameSong.mp3";
            shootgMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            // Startup Loaded Songs
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;
            gameMedia.controls.play();


            // Load Images
            Image munition = Image.FromFile(@"asserts\\munition.png");
            Image enemy1 = Image.FromFile(@"asserts\\E1.png");
            Image enemy2 = Image.FromFile(@"asserts\\E2.png");
            Image enemy3 = Image.FromFile(@"asserts\\E3.png");
            Image boss1 = Image.FromFile(@"asserts\\Boss1.png");
            Image boss2 = Image.FromFile(@"asserts\\Boss2.png");

            //Initialize Enemies PictureBox
            enemies = new PictureBox[10];

            // Load Enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy1;
            enemies[5].Image = enemy1;
            enemies[6].Image = enemy2;
            enemies[7].Image = enemy3;
            enemies[8].Image = enemy2;
            enemies[9].Image = boss2;


            // Load Munitions
            for (int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            // Load Stars
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-20, 420));
                
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                    
                } else {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            // Load Enemies Munition
            enemiesMunition = new PictureBox[10];

            for(int i = 0; i < enemiesMunition.Length; i++)
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(2, 25);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }
        }

        private void Move_Background_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerspeed;
            }
        }

        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerspeed;
            }
        }

        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerspeed;
            }
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerspeed;
            }
        }

        private void Space_Invaders_KeyDown(object sender, KeyEventArgs e)
        {
            if(!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    MoveRightTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    MoveLeftTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveDownTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    MoveUpTimer.Start();
                }
            }
        }

        private void Space_Invaders_KeyUp(object sender, KeyEventArgs e)
        {
            MoveRightTimer.Stop();
            MoveLeftTimer.Stop();
            MoveUpTimer.Stop();
            MoveDownTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        Game_Over.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        Game_Over.Location = new Point(this.Width / 2 - 140, 180);
                        Game_Over.Size = new Size(257,54);
                        Game_Over.Text = "PAUSED";
                        Game_Over.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                } 
            }
        }

        private void MoveMunitionsTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 10)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;

                    Collision();
                } else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemySpeed);
        }
        private void MoveEnemies(PictureBox[] array, int speed)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void Collision()
        {
            for(int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) || 
                    munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || 
                    munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score += 1;
                    Label_Score.Text = (score < 10) ? "Score: 0" + score.ToString() : "Score: " + score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        Label_Level.Text = (level < 10) ? "Level: 0" + level.ToString() : "Level: " + level.ToString();

                        if (enemySpeed <= 10 && enemiesMunitionSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemiesMunitionSpeed++;
                        }
                        if (level == 10)
                        {
                            GameOver("GAME WON");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -50);
                }
                
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("GAME OVER");
                }
            }
        }
        private void GameOver(string str)
        {
            Game_Over.Text = str;
            Game_Over.Location = new Point(110, 150);
            Game_Over.Size = new Size(257, 54);
            Game_Over.Visible = true;
            ReplayBtn.Visible = true;
            ExitBtn.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }
        private void StopTimers()
        {
            Move_Background.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionsTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }
        private void StartTimers()
        {
            Move_Background.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionsTimer.Start();
            EnemiesMunitionTimer.Start();
        }

        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < (enemiesMunition.Length - difficulty); i++)
            {
                if (enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;

                    CollisionWithEnemiesMunition();
                } else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }
        private void CollisionWithEnemiesMunition()
        {
            for(int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    MoveUpTimer.Stop();
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("GAME OVER");
                }
            }
        }

        private void ReplayBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Space_Invaders_Load(e, e);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

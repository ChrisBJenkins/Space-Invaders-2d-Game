
namespace Space_Invaders
{
    partial class Space_Invaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Space_Invaders));
            this.Move_Background = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMunitionsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMunitionTimer = new System.Windows.Forms.Timer(this.components);
            this.ReplayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Game_Over = new System.Windows.Forms.Label();
            this.Label_Score = new System.Windows.Forms.Label();
            this.Label_Level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Move_Background
            // 
            this.Move_Background.Enabled = true;
            this.Move_Background.Interval = 10;
            this.Move_Background.Tick += new System.EventHandler(this.Move_Background_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Player.ErrorImage")));
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(260, 400);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Interval = 5;
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveRightTimer
            // 
            this.MoveRightTimer.Interval = 5;
            this.MoveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // MoveUpTimer
            // 
            this.MoveUpTimer.Interval = 5;
            this.MoveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Interval = 5;
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // MoveMunitionsTimer
            // 
            this.MoveMunitionsTimer.Enabled = true;
            this.MoveMunitionsTimer.Interval = 20;
            this.MoveMunitionsTimer.Tick += new System.EventHandler(this.MoveMunitionsTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMunitionTimer
            // 
            this.EnemiesMunitionTimer.Enabled = true;
            this.EnemiesMunitionTimer.Interval = 20;
            this.EnemiesMunitionTimer.Tick += new System.EventHandler(this.EnemiesMunitionTimer_Tick);
            // 
            // ReplayBtn
            // 
            this.ReplayBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReplayBtn.FlatAppearance.BorderSize = 0;
            this.ReplayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplayBtn.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayBtn.ForeColor = System.Drawing.Color.Snow;
            this.ReplayBtn.Location = new System.Drawing.Point(160, 224);
            this.ReplayBtn.MinimumSize = new System.Drawing.Size(257, 54);
            this.ReplayBtn.Name = "ReplayBtn";
            this.ReplayBtn.Size = new System.Drawing.Size(257, 55);
            this.ReplayBtn.TabIndex = 1;
            this.ReplayBtn.Text = "Replay";
            this.ReplayBtn.UseVisualStyleBackColor = false;
            this.ReplayBtn.Visible = false;
            this.ReplayBtn.Click += new System.EventHandler(this.ReplayBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Snow;
            this.ExitBtn.Location = new System.Drawing.Point(160, 296);
            this.ExitBtn.MinimumSize = new System.Drawing.Size(257, 54);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(257, 56);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Game_Over
            // 
            this.Game_Over.AutoSize = true;
            this.Game_Over.BackColor = System.Drawing.Color.Transparent;
            this.Game_Over.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Game_Over.Location = new System.Drawing.Point(160, 154);
            this.Game_Over.MinimumSize = new System.Drawing.Size(257, 54);
            this.Game_Over.Name = "Game_Over";
            this.Game_Over.Size = new System.Drawing.Size(257, 58);
            this.Game_Over.TabIndex = 3;
            this.Game_Over.Text = "label1";
            this.Game_Over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Game_Over.Visible = false;
            // 
            // Label_Score
            // 
            this.Label_Score.AutoSize = true;
            this.Label_Score.BackColor = System.Drawing.Color.Transparent;
            this.Label_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Score.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Score.ForeColor = System.Drawing.Color.Yellow;
            this.Label_Score.Location = new System.Drawing.Point(10, 10);
            this.Label_Score.MinimumSize = new System.Drawing.Size(70, 20);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(130, 25);
            this.Label_Score.TabIndex = 4;
            this.Label_Score.Text = "Score: 00";
            this.Label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Level
            // 
            this.Label_Level.AutoSize = true;
            this.Label_Level.BackColor = System.Drawing.Color.Transparent;
            this.Label_Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_Level.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Level.ForeColor = System.Drawing.Color.Yellow;
            this.Label_Level.Location = new System.Drawing.Point(451, 10);
            this.Label_Level.MinimumSize = new System.Drawing.Size(70, 20);
            this.Label_Level.Name = "Label_Level";
            this.Label_Level.Size = new System.Drawing.Size(127, 25);
            this.Label_Level.TabIndex = 5;
            this.Label_Level.Text = "Level: 00";
            this.Label_Level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Space_Invaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Game_Over);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReplayBtn);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Label_Level);
            this.Controls.Add(this.Label_Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Space_Invaders";
            this.Text = "Space Invader";
            this.Load += new System.EventHandler(this.Space_Invaders_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Space_Invaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Space_Invaders_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Move_Background;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRightTimer;
        private System.Windows.Forms.Timer MoveUpTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer MoveMunitionsTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMunitionTimer;
        private System.Windows.Forms.Button ReplayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Game_Over;
        private System.Windows.Forms.Label Label_Score;
        private System.Windows.Forms.Label Label_Level;
    }
}


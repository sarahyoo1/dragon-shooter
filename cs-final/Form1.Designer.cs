
namespace cs_final
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackgroundMoveSpeed = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.FireMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemySpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.ItemSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.ItemMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.SpeedUpDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.PowerUpDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTheme = new AxWMPLib.AxWindowsMediaPlayer();
            this.fireShootingSound1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.enemyDamagedSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.enemyDestroyedSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.heartItemSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.powerupItemSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.speedupItemSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.playerDamagedSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.gameOverMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.gameover_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.lives_label = new System.Windows.Forms.Label();
            this.final_score_label = new System.Windows.Forms.Label();
            this.replay_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.fireShootingSound2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.fireShootingSound3 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDamagedSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDestroyedSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartItemSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerupItemSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedupItemSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDamagedSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound3)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundMoveSpeed
            // 
            this.BackgroundMoveSpeed.Enabled = true;
            this.BackgroundMoveSpeed.Interval = 10;
            this.BackgroundMoveSpeed.Tick += new System.EventHandler(this.BackgroundMoveSpeed_Tick);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(330, 329);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(120, 120);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // FireMoveTimer
            // 
            this.FireMoveTimer.Enabled = true;
            this.FireMoveTimer.Interval = 20;
            this.FireMoveTimer.Tick += new System.EventHandler(this.FireMoveTimer_Tick);
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 20;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // EnemySpawnTimer
            // 
            this.EnemySpawnTimer.Enabled = true;
            this.EnemySpawnTimer.Interval = 2000;
            this.EnemySpawnTimer.Tick += new System.EventHandler(this.EnemySpawnTimer_Tick);
            // 
            // ItemSpawnTimer
            // 
            this.ItemSpawnTimer.Enabled = true;
            this.ItemSpawnTimer.Interval = 5000;
            this.ItemSpawnTimer.Tick += new System.EventHandler(this.ItemSpawnTimer_Tick);
            // 
            // ItemMoveTimer
            // 
            this.ItemMoveTimer.Enabled = true;
            this.ItemMoveTimer.Interval = 20;
            this.ItemMoveTimer.Tick += new System.EventHandler(this.ItemMoveTimer_Tick);
            // 
            // SpeedUpDurationTimer
            // 
            this.SpeedUpDurationTimer.Interval = 5000;
            this.SpeedUpDurationTimer.Tick += new System.EventHandler(this.SpeedUpDurationTimer_Tick);
            // 
            // PowerUpDurationTimer
            // 
            this.PowerUpDurationTimer.Interval = 30000;
            this.PowerUpDurationTimer.Tick += new System.EventHandler(this.PowerUpDurationTimer_Tick);
            // 
            // mainTheme
            // 
            this.mainTheme.Enabled = true;
            this.mainTheme.Location = new System.Drawing.Point(125, 12);
            this.mainTheme.Name = "mainTheme";
            this.mainTheme.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainTheme.OcxState")));
            this.mainTheme.Size = new System.Drawing.Size(75, 23);
            this.mainTheme.TabIndex = 4;
            this.mainTheme.Visible = false;
            // 
            // fireShootingSound1
            // 
            this.fireShootingSound1.Enabled = true;
            this.fireShootingSound1.Location = new System.Drawing.Point(226, 12);
            this.fireShootingSound1.Name = "fireShootingSound1";
            this.fireShootingSound1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fireShootingSound1.OcxState")));
            this.fireShootingSound1.Size = new System.Drawing.Size(75, 23);
            this.fireShootingSound1.TabIndex = 5;
            this.fireShootingSound1.Visible = false;
            // 
            // enemyDamagedSound
            // 
            this.enemyDamagedSound.Enabled = true;
            this.enemyDamagedSound.Location = new System.Drawing.Point(330, 12);
            this.enemyDamagedSound.Name = "enemyDamagedSound";
            this.enemyDamagedSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("enemyDamagedSound.OcxState")));
            this.enemyDamagedSound.Size = new System.Drawing.Size(75, 23);
            this.enemyDamagedSound.TabIndex = 6;
            this.enemyDamagedSound.Visible = false;
            // 
            // enemyDestroyedSound
            // 
            this.enemyDestroyedSound.Enabled = true;
            this.enemyDestroyedSound.Location = new System.Drawing.Point(432, 12);
            this.enemyDestroyedSound.Name = "enemyDestroyedSound";
            this.enemyDestroyedSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("enemyDestroyedSound.OcxState")));
            this.enemyDestroyedSound.Size = new System.Drawing.Size(75, 23);
            this.enemyDestroyedSound.TabIndex = 7;
            this.enemyDestroyedSound.Visible = false;
            // 
            // heartItemSound
            // 
            this.heartItemSound.Enabled = true;
            this.heartItemSound.Location = new System.Drawing.Point(527, 12);
            this.heartItemSound.Name = "heartItemSound";
            this.heartItemSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("heartItemSound.OcxState")));
            this.heartItemSound.Size = new System.Drawing.Size(75, 23);
            this.heartItemSound.TabIndex = 8;
            this.heartItemSound.Visible = false;
            // 
            // powerupItemSound
            // 
            this.powerupItemSound.Enabled = true;
            this.powerupItemSound.Location = new System.Drawing.Point(622, 12);
            this.powerupItemSound.Name = "powerupItemSound";
            this.powerupItemSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("powerupItemSound.OcxState")));
            this.powerupItemSound.Size = new System.Drawing.Size(75, 23);
            this.powerupItemSound.TabIndex = 9;
            this.powerupItemSound.Visible = false;
            // 
            // speedupItemSound
            // 
            this.speedupItemSound.Enabled = true;
            this.speedupItemSound.Location = new System.Drawing.Point(125, 50);
            this.speedupItemSound.Name = "speedupItemSound";
            this.speedupItemSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("speedupItemSound.OcxState")));
            this.speedupItemSound.Size = new System.Drawing.Size(75, 23);
            this.speedupItemSound.TabIndex = 10;
            this.speedupItemSound.Visible = false;
            // 
            // playerDamagedSound
            // 
            this.playerDamagedSound.Enabled = true;
            this.playerDamagedSound.Location = new System.Drawing.Point(226, 50);
            this.playerDamagedSound.Name = "playerDamagedSound";
            this.playerDamagedSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerDamagedSound.OcxState")));
            this.playerDamagedSound.Size = new System.Drawing.Size(75, 23);
            this.playerDamagedSound.TabIndex = 11;
            this.playerDamagedSound.Visible = false;
            // 
            // gameOverMusic
            // 
            this.gameOverMusic.Enabled = true;
            this.gameOverMusic.Location = new System.Drawing.Point(330, 50);
            this.gameOverMusic.Name = "gameOverMusic";
            this.gameOverMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gameOverMusic.OcxState")));
            this.gameOverMusic.Size = new System.Drawing.Size(75, 23);
            this.gameOverMusic.TabIndex = 12;
            this.gameOverMusic.Visible = false;
            // 
            // gameover_label
            // 
            this.gameover_label.AutoSize = true;
            this.gameover_label.BackColor = System.Drawing.Color.Transparent;
            this.gameover_label.Font = new System.Drawing.Font("휴먼둥근헤드라인", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gameover_label.ForeColor = System.Drawing.Color.Red;
            this.gameover_label.Location = new System.Drawing.Point(217, 113);
            this.gameover_label.Name = "gameover_label";
            this.gameover_label.Size = new System.Drawing.Size(356, 50);
            this.gameover_label.TabIndex = 13;
            this.gameover_label.Text = "Game Over";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(12, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(115, 29);
            this.score_label.TabIndex = 14;
            this.score_label.Text = "Score: 0";
            // 
            // lives_label
            // 
            this.lives_label.AutoSize = true;
            this.lives_label.BackColor = System.Drawing.Color.Transparent;
            this.lives_label.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives_label.ForeColor = System.Drawing.Color.White;
            this.lives_label.Location = new System.Drawing.Point(12, 44);
            this.lives_label.Name = "lives_label";
            this.lives_label.Size = new System.Drawing.Size(99, 29);
            this.lives_label.TabIndex = 15;
            this.lives_label.Text = "lives: 3";
            // 
            // final_score_label
            // 
            this.final_score_label.AutoSize = true;
            this.final_score_label.BackColor = System.Drawing.Color.Transparent;
            this.final_score_label.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_score_label.ForeColor = System.Drawing.Color.White;
            this.final_score_label.Location = new System.Drawing.Point(352, 191);
            this.final_score_label.Name = "final_score_label";
            this.final_score_label.Size = new System.Drawing.Size(98, 29);
            this.final_score_label.TabIndex = 16;
            this.final_score_label.Text = "Score: ";
            // 
            // replay_btn
            // 
            this.replay_btn.Font = new System.Drawing.Font("HY중고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.replay_btn.Location = new System.Drawing.Point(253, 255);
            this.replay_btn.Name = "replay_btn";
            this.replay_btn.Size = new System.Drawing.Size(130, 33);
            this.replay_btn.TabIndex = 17;
            this.replay_btn.Text = "Replay";
            this.replay_btn.UseVisualStyleBackColor = true;
            this.replay_btn.Click += new System.EventHandler(this.replay_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("HY중고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit_btn.Location = new System.Drawing.Point(417, 255);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(130, 33);
            this.exit_btn.TabIndex = 19;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // fireShootingSound2
            // 
            this.fireShootingSound2.Enabled = true;
            this.fireShootingSound2.Location = new System.Drawing.Point(432, 50);
            this.fireShootingSound2.Name = "fireShootingSound2";
            this.fireShootingSound2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fireShootingSound2.OcxState")));
            this.fireShootingSound2.Size = new System.Drawing.Size(75, 23);
            this.fireShootingSound2.TabIndex = 20;
            this.fireShootingSound2.Visible = false;
            // 
            // fireShootingSound3
            // 
            this.fireShootingSound3.Enabled = true;
            this.fireShootingSound3.Location = new System.Drawing.Point(527, 50);
            this.fireShootingSound3.Name = "fireShootingSound3";
            this.fireShootingSound3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fireShootingSound3.OcxState")));
            this.fireShootingSound3.Size = new System.Drawing.Size(75, 23);
            this.fireShootingSound3.TabIndex = 21;
            this.fireShootingSound3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.fireShootingSound3);
            this.Controls.Add(this.fireShootingSound2);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.replay_btn);
            this.Controls.Add(this.final_score_label);
            this.Controls.Add(this.lives_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.gameover_label);
            this.Controls.Add(this.gameOverMusic);
            this.Controls.Add(this.playerDamagedSound);
            this.Controls.Add(this.speedupItemSound);
            this.Controls.Add(this.powerupItemSound);
            this.Controls.Add(this.heartItemSound);
            this.Controls.Add(this.enemyDestroyedSound);
            this.Controls.Add(this.enemyDamagedSound);
            this.Controls.Add(this.fireShootingSound1);
            this.Controls.Add(this.mainTheme);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Dragon Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDamagedSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDestroyedSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartItemSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerupItemSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedupItemSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDamagedSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShootingSound3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer BackgroundMoveSpeed;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer FireMoveTimer;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer EnemySpawnTimer;
        private System.Windows.Forms.Timer ItemSpawnTimer;
        private System.Windows.Forms.Timer ItemMoveTimer;
        private System.Windows.Forms.Timer SpeedUpDurationTimer;
        private System.Windows.Forms.Timer PowerUpDurationTimer;
        private AxWMPLib.AxWindowsMediaPlayer mainTheme;
        private AxWMPLib.AxWindowsMediaPlayer fireShootingSound1;
        private AxWMPLib.AxWindowsMediaPlayer enemyDamagedSound;
        private AxWMPLib.AxWindowsMediaPlayer enemyDestroyedSound;
        private AxWMPLib.AxWindowsMediaPlayer heartItemSound;
        private AxWMPLib.AxWindowsMediaPlayer powerupItemSound;
        private AxWMPLib.AxWindowsMediaPlayer speedupItemSound;
        private AxWMPLib.AxWindowsMediaPlayer playerDamagedSound;
        private AxWMPLib.AxWindowsMediaPlayer gameOverMusic;
        private System.Windows.Forms.Label gameover_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label lives_label;
        private System.Windows.Forms.Label final_score_label;
        private System.Windows.Forms.Button replay_btn;
        private System.Windows.Forms.Button exit_btn;
        private AxWMPLib.AxWindowsMediaPlayer fireShootingSound2;
        private AxWMPLib.AxWindowsMediaPlayer fireShootingSound3;
    }
}


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

namespace cs_final
{
    public partial class Form1 : Form
    {
        //Sets max lives, max power level, and max speed level.
        const int _max_power_lvl = 2;
        const int _max_speed_lvl = 2;
        const int _max_lives = 10;

        //Initializes player's stats.
        int playerSpeed;
        int lives;
        int score;
        int power_lvl;
        int speed_lvl;
        int damage;

        //initializes lists that will contain objects created during the game.
        List<PictureBox> stars; //star picture box list.
        int backgroundSpeed; //the speed of stars in the background.

        List<PictureBox> fires; //fire picturebox.
        int fireSpeed; //fire moving speed
        Image fireImage; //fire image.

        List<Enemy> enemies; //will contain enemy objects
        public static int enemyMunitionSpeed; //Sets enemy munition speed.

        List<PictureBox> items; //item picturebox list.
        int itemSpeed; //item moving speed.

        //Declares random syntax.
        Random rd = new Random();

        //initializes all level of fire bullet images
        Image fire_level1_img = Image.FromFile(@"assets\fire\fire-level1.png");
        Image fire_level2_img = Image.FromFile(@"assets\fire\fire-level2.png");
        Image fire_level3_img = Image.FromFile(@"assets\fire\fire-level3.png");

        //initializes all enemy images.
        public static Image enemy1_img = Image.FromFile(@"assets\enemy\enemy-1.png");
        public static Image enemy2_img = Image.FromFile(@"assets\enemy\enemy-2.png");
        public static Image enemy3_img = Image.FromFile(@"assets\enemy\enemy-3.png");
        public static Image enemy4_img = Image.FromFile(@"assets\enemy\enemy-4.png");
        public static Image enemy5_img = Image.FromFile(@"assets\enemy\enemy-5.png");

        //initializes item images.
        Image heart_img = Image.FromFile(@"assets\items\heart.png");
        Image speedup_img = Image.FromFile(@"assets\items\speedup.png");
        Image powerup_img = Image.FromFile(@"assets\items\powerup.png");

        public Form1()
        {
            //initializes components when the form is loaded.
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            //initializes music urls.
            mainTheme.URL = @"sounds\musics\battleTheme.wav";
            gameOverMusic.URL = @"sounds\musics\game-over-music.wav";

            //intializes sound effect urls.
            fireShootingSound1.URL = @"sounds\sound-effects\fire-level1-sound.wav";
            fireShootingSound2.URL = @"sounds\sound-effects\fire-level2-sound.wav";
            fireShootingSound3.URL = @"sounds\sound-effects\fire-level3-sound.wav";
            enemyDamagedSound.URL = @"sounds\sound-effects\enemy-damaged-sound.wav";
            enemyDestroyedSound.URL = @"sounds\sound-effects\enemy-destroyed-sound.wav";
            heartItemSound.URL = @"sounds\sound-effects\heart-sound.wav";
            powerupItemSound.URL = @"sounds\sound-effects\powerup-sound.wav";
            speedupItemSound.URL = @"sounds\sound-effects\speedup-sound.wav";
            playerDamagedSound.URL = @"sounds\sound-effects\player-damaged-sound.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets initial settings.
            backgroundSpeed = 4;
            playerSpeed = 4;
            fireSpeed = 12;
            itemSpeed = 2;
            enemyMunitionSpeed = 10;

            //Sets the player stats values.
            lives = 3;
            score = 0;
            power_lvl = 0;
            speed_lvl = 0;
            damage = 1;

            //Declares lists.
            stars = new List<PictureBox>();
            fires = new List<PictureBox>();
            items = new List<PictureBox>();
            enemies = new List<Enemy>();
            fireImage = fire_level1_img; //set initial fire image to be level 1.

            //Sets the score label.
            score_label.Text = "Score:" + score;
            score_label.BringToFront();

            //Sets lives label.
            lives_label.Text = "Lives: " + lives;
            lives_label.BringToFront();

            //Turns off the visibilities of gameover label, final score label, and replay button.
            gameover_label.Visible = false;
            final_score_label.Visible = false;
            replay_btn.Visible = false;
            exit_btn.Visible = false;

            //Plays main battle theme.
            mainTheme.Ctlcontrols.play();
           
            //Generates stars on the background.
            GenerateStarsOnBackground();
        }


        //*****************  Methods *********************

        public void GenerateStarsOnBackground()
        {
            //Generates random stars on the background.
            for (int i = 0; i < 30; i++)
            {
                //Creates a new star.
                PictureBox star = new PictureBox();
                //Designs the star.
                star.BorderStyle = BorderStyle.None;
                star.Location = new Point(rd.Next(20, 780), rd.Next(-10, 500));

                //Sets the size and color of the star (Randomly).
                int randomNum = rd.Next(1, 5);
                if (randomNum == 2)
                {
                    //Creates a white star when the number is 2.
                    star.Size = new Size(2, 2);
                    star.BackColor = Color.White;
                }
                else if (randomNum == 4)
                {
                    //Creates a yellow star when the number is 4.
                    star.Size = new Size(1, 1);
                    star.BackColor = Color.Yellow;
                }

                //Adds the created new star to the 'star' array.
                this.Controls.Add(star);
                stars.Add(star);
            }
        }


        //Enables the stars on the background to move. (using timer)
        private void BackgroundMoveSpeed_Tick(object sender, EventArgs e)
        {
            //Makes each star move down.
            foreach (PictureBox star in stars)
            {
                star.Top += backgroundSpeed; //goes down faster depending on the backgroundSpeed.

                //relocates the stars if the stars go over the window.
                if (star.Top >= this.Height)
                {
                    star.Location = new Point(rd.Next(10, 790), -star.Height);
                }
            }
        }

        //Controller Settings
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) //if the key Right or D was pressed
            {
                RightMoveTimer.Start(); //Moves to the right.
            } 
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) //if the key Left or A was pressed
            {
                LeftMoveTimer.Start(); //Moves to the left.
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S) //if the key Down or S was pressed
            {
                DownMoveTimer.Start(); //Moves down.
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) //if the key Up or W was pressed
            {
                UpMoveTimer.Start(); //Moves up.
            }
            if (e.KeyCode == Keys.Space) //if the spacebar was pressed
            {
                //shoots fire.
                ShootFire();
            }
        }

        //Stops the move timers when keys were up.
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();
        }

        //Moving up logic (timer)
        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            //moves up.
            if (Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }
        }

        //Moving down logic (timer)
        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            //movesdown.
            if (Player.Top < 500)
            {
                Player.Top += playerSpeed;
            }
        }

        //Moving left logic (timer).
        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            //moves to the left.
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        //Moving right logic (timer)
        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            //moves to the right.
            if (Player.Right < 790)
            {
                Player.Left += playerSpeed;
            }
        }

        //Dragon shoots fire.
        private void ShootFire()
        {
            //Creates a new fire bullet.
            PictureBox fire = new PictureBox();
            fire.Image = fireImage;

            if (fireImage == fire_level1_img) //if the fire image is fire_level1
            {
                fire.Size = new Size(40, 40); //sets the size of the fire.
                fire.Location = new Point(Player.Location.X + 40, Player.Location.Y - 15); //sets the location of the fire.

                //Plays fire level 1 shooting sound.
                fireShootingSound1.Ctlcontrols.play();

            } else if (fireImage == fire_level2_img) //if fire image is fire_level2
            {
                fire.Size = new Size(100, 50); //sets the size of the fire.
                fire.Location = new Point(Player.Location.X + 7, Player.Location.Y - 10); //sets the location of the fire.

                //Plays fire level 2 shooting sound.
                fireShootingSound2.Ctlcontrols.play();

            } else //if the fire image is fire_level3
            {
                fire.Size = new Size(85, 110); //sets the size of the fire.
                fire.Location = new Point(Player.Location.X + 24, Player.Location.Y - 95); //sets the location of the fire.

                //Plays fire level 3 shooting sound.
                fireShootingSound3.Ctlcontrols.play();
            }

            //general fire sizemode and borderstyle settings.
            fire.SizeMode = PictureBoxSizeMode.StretchImage;
            fire.BorderStyle = BorderStyle.None;
           
            //adds the fire to controls.
            this.Controls.Add(fire);
            fire.BringToFront(); //brings the fire picturebox to the front so that not hidden by other picture boxes.
            fires.Add(fire); //adds the new fire to fires list.

            //makes the fire moves up.
            FireMoveTimer.Start();
        }

        //Moves fires and deletes them if they go over the game window.
        private void FireMoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = fires.Count - 1; i >= 0; i--)
            {
                PictureBox fire = fires[i];
                fire.Top -= fireSpeed; //makes the fire moves up.

                if (fire.Top > 500) //if the fire goes over 500
                {
                    //removes the fire.
                    this.Controls.Remove(fire);
                    fires.RemoveAt(i);
                    fire.Dispose();
                }
            }
        }

        //Spawns random enemies.
        public void SpawnEnemies()
        {
            int randomNum = rd.Next(1, 6);

            Image image;
            switch (randomNum)
            {
                case 1: //if the random number is 1
                    image = enemy1_img; //sets the enemy image to be enemy1.
                    break;
                case 2://if the random number is 2
                    image = enemy2_img; //sets the enemy image to be enemy2.
                    break;
                case 3://if the random number is 3
                    image = enemy3_img; //sets the enemy image to be enemy3.
                    break;
                case 4: //if the random number is 4
                    image = enemy4_img; //sets the enemy image to be enemy4.
                    break;
                case 5: //if the random number is 5
                    image = enemy5_img; //sets the enemy image to be enemy5.
                    break;
                default: //for any other numbers
                    image = enemy1_img; //sets the enemy image to be enemy1.
                    break;
            }

            //Creates a new enemy object.
            Enemy enemy = new Enemy(image, new Point(rd.Next(20, 720), -50), new Size(80, 80), this.Controls);

            //adds the created enemy to controls.
            this.Controls.Add(enemy.EnemyPictureBox);
            enemy.EnemyPictureBox.BringToFront();
            enemies.Add(enemy);

            //makes the enemy move.
            EnemyMoveTimer.Start();
        }

        //Moves enemies.
        private void EnemyMoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = enemies.Count - 1; i >=0; i --)
            {
                Enemy enemy = enemies[i];
                enemy.EnemyPictureBox.Top += enemy.Speed; //makes enemies move down.

                //Detects collision.
                Collision();

                if (enemy.EnemyPictureBox.Top > 500) //if the enemy goes over 500
                {
                    //Stops shooting
                    enemies[i].StopShooting();

                    //removes the enemy.
                    this.Controls.Remove(enemy.EnemyPictureBox);
                    enemies.RemoveAt(i);
                    enemy.EnemyPictureBox.Dispose();
                }
            }
        }

        //Enables to spawn enemies.
        private void EnemySpawnTimer_Tick(object sender, EventArgs e)
        {
            SpawnEnemies(); //spawn enemies.
        }

        //Spawn items: heart, power up, and speed up.
        public void SpawnItems ()
        {
            int randomNum = rd.Next(1, 4);

            if (randomNum == 1 && lives < _max_lives) //if the number is 1, and  the lives is less than max lives
            {
                //creates heart item.
                PictureBox heartItem = new PictureBox();
                heartItem.Size = new Size(20, 20);
                heartItem.Image = heart_img;
                heartItem.SizeMode = PictureBoxSizeMode.Zoom;
                heartItem.BorderStyle = BorderStyle.None;
                heartItem.Location = new Point(rd.Next(20, 720), -20);

                //adds the created heart item to controls.
                this.Controls.Add(heartItem);
                items.Add(heartItem);
            } else if (randomNum == 2 && speed_lvl < _max_speed_lvl) //if the number is 2, and the current speed level is less than max speed level.
            {
                //Create speed up itmem.
                PictureBox speedupItem = new PictureBox();
                speedupItem.Size = new Size(20, 20);
                speedupItem.Image = speedup_img;
                speedupItem.SizeMode = PictureBoxSizeMode.Zoom;
                speedupItem.BorderStyle = BorderStyle.None;
                speedupItem.Location = new Point(rd.Next(20, 720), -20);

                //adds the speed item to controls.
                this.Controls.Add(speedupItem);
                items.Add(speedupItem);
            } else if (randomNum == 3 && power_lvl < _max_power_lvl) //if the number is 3, and the current power is less than max power level.
            {
                //creates powerup item.
                PictureBox powerupItem = new PictureBox();
                powerupItem.Size = new Size(20, 20);
                powerupItem.Image = powerup_img;
                powerupItem.SizeMode = PictureBoxSizeMode.Zoom;
                powerupItem.BorderStyle = BorderStyle.None;
                powerupItem.Location = new Point(rd.Next(20, 720), -20);

                //adds the power up item to controls.
                this.Controls.Add(powerupItem);
                items.Add(powerupItem);
            }

            //enables items to move.
            ItemMoveTimer.Start();
        }

        //Spawns items in certain intervals.
        private void ItemSpawnTimer_Tick(object sender, EventArgs e)
        {
            //spawn items.
            SpawnItems();
        }

        //Makes items move in specific intervals. (timer)
        private void ItemMoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
               
                items[i].Top += itemSpeed; //makes enemies move down.

                if (items[i].Top > 500) //if the enemy goes over 500
                {
                    //removes the enemy.
                    this.Controls.Remove(items[i]);
                    items[i].Dispose();
                    items.RemoveAt(i);
                }

                //Detects collision.
                Collision();
            }
        }

        //Detects collisions.
        public  void Collision()
        {
            // Checks for fire-enemy collisions
            for (int f = fires.Count - 1; f >= 0; f --)
            {
                for (int e = enemies.Count - 1; e >= 0; e --)
                {
                    Enemy enemy = enemies[e]; //access each enemy class.
                    if (fires[f].Bounds.IntersectsWith(enemy.EnemyPictureBox.Bounds)) //if a fire collides with an enemy
                    {
                        //plays enemy damaged sound effect.
                        enemyDamagedSound.Ctlcontrols.play();

                        //deducts enemy's hp.
                        enemy.HP -= damage; //applies damage depending on the player's current power level.
                        
                        if (enemy.HP <= 0) //when the enemy dies
                        {
           
                            if (enemy.EnemyPictureBox.Image == enemy1_img) //if it is enemy 1
                            {
                                score++; //scores 1.
                            }
                            else if (enemy.EnemyPictureBox.Image == enemy2_img) //if it is enemy 2
                            {
                                score += 2; //scores 2.
                            }
                            else if (enemy.EnemyPictureBox.Image == enemy3_img) //if it is enemy 3
                            {
                                score += 3; //scores 3.
                            } 
                            else if (enemy.EnemyPictureBox.Image == enemy4_img) //if it is enemy 4
                            {
                                score += 4; //scores 4.
                            }
                            else //if it is enemy 5
                            {
                                score += 5; //scores 5.
                            }

                            //plays enemy destroyed sound effect.
                            enemyDamagedSound.Ctlcontrols.play();

                            //Stops shooting
                            enemies[e].StopShooting();

                            // Removes the collided enemy
                            this.Controls.Remove(enemy.EnemyPictureBox);
                            enemy.EnemyPictureBox.Dispose();
                            enemies.RemoveAt(e);

                            //Updates score label.
                            UpdateScore();
                        }

                        // Removes the collided fire
                        this.Controls.Remove(fires[f]);
                        fires[f].Dispose();
                        fires.RemoveAt(f);

                        break; // Exits the inner loop after collision
                    }
                }
            }

            // Checks for player-enemy collisions
            for (int e = enemies.Count - 1; e >= 0; e --)
            {
                PictureBox enemyPicturebox = enemies[e].EnemyPictureBox;
                if (Player.Bounds.IntersectsWith(enemyPicturebox.Bounds)) //if the player collides with an enemy
                {
                    //Stops shooting
                    enemies[e].StopShooting();

                    // Removes the collided enemy
                    this.Controls.Remove(enemyPicturebox);
                    enemyPicturebox.Dispose();
                    enemies.RemoveAt(e);

                    //plays player damaged sound effect.
                    playerDamagedSound.Ctlcontrols.play();

                    //deducts player's lives by one.
                    lives--;

                    //updates current lives label.
                    UpdateLives();

                    if (lives <= 0) //if the player dies
                    {
                        // Removes player if lives is 0.
                        this.Controls.Remove(Player);
                        Player.Dispose();

                        //Sets game over.
                        GameOver();
                    } 
                    
                    break; // Game over or lose a life
                }
            }

            //Checks for player-item collisions
            for (int i = items.Count - 1; i >= 0; i --)
            {
                if (Player.Bounds.IntersectsWith(items[i].Bounds)) //when the player collides with an item
                {
                    if (items[i].Image == heart_img) //in case of a heart item
                    {
                        //adds one life.
                        lives ++;
                        //plays picking up heart item sound effect.
                        heartItemSound.Ctlcontrols.play();

                        //updates lives score label.
                        UpdateLives();
                    } else if (items[i].Image == speedup_img) //in case of speed up item
                    {
                        //increases speed level by one.
                        speed_lvl ++;

                        //playes picking up speed up item sound effect.
                        speedupItemSound.Ctlcontrols.play();

                        //updates player's movement speed.
                        UpdateSpeed();

                        //Sets speed up duration.
                        SpeedUpDurationTimer.Stop(); //starts new session.
                        SpeedUpDurationTimer.Start();
                    } else //in case of power up item
                    {
                        //increases power level by one.
                        power_lvl ++;

                        //plays picking up power up item sound effect.
                        powerupItemSound.Ctlcontrols.play();

                        //updates player's fire skin.
                        UpdatePower();

                        //sets current power duration.
                        PowerUpDurationTimer.Stop(); //starts new session.
                        PowerUpDurationTimer.Start();
                    }

                    //Removes the collided item.
                    this.Controls.Remove(items[i]);
                    items[i].Dispose();
                    items.RemoveAt(i);

                    break;
                }
            }

            //Checks for player - enemy munitions collision.
            for (int e = enemies.Count - 1; e >= 0; e --)
            {
                Enemy enemy = enemies[e]; //access each enemy

                for (int m = enemy.munitions.Count - 1; m >= 0; m -- )
                {
                    PictureBox munition = enemy.munitions[m];
                    if (Player.Bounds.IntersectsWith(munition.Bounds)) //when the player collides with an enemy's munition
                    {
                        // Removes the collided enemyMunition
                        this.Controls.Remove(munition);
                        munition.Dispose();
                        enemy.munitions.RemoveAt(m);

                         //plays player damaged sound effect.
                         playerDamagedSound.Ctlcontrols.play();

                         //deducts player's lives by one.
                         lives--;

                         //updates current lives label.
                         UpdateLives();
                       
                        if (lives <= 0) //if the player dies
                        {
                            // Removes player if lives is 0.
                            this.Controls.Remove(Player);
                            Player.Dispose();

                            //Sets game over.
                            GameOver();
                        }

                        break; // Game over or lose a life
                    }
                }
            }
        }

        //Updates score label.
        private void UpdateScore()
        {
            score_label.Text = "Score: " + score; 
        }

        //Updates lives label.
        private void UpdateLives()
        {
            lives_label.Text = "Lives: " + lives;
        }


        //Updates speed depending on the current speed level.
        private void UpdateSpeed()
        {
            switch (speed_lvl)
            {
                case 1: //if the speed level is 1
                    playerSpeed = 6; //sets the player's speed to be 6.
                    break;
                case 2: //if the speed level is 2
                    playerSpeed = 10; //sets the player's speed to be 6.
                    break;
                default: //in default: 
                    playerSpeed = 4; //sets the player's speed to be 6.
                    break;
            }

            //Sets duration for speed up condition.
            SpeedUpDurationTimer.Start();
        }

        //Updates power depending on the current power level.
        private void UpdatePower()
        {
            switch (power_lvl)
            {
                case 1: //if the power level is 1
                    fireImage = fire_level2_img; //sets fire image to be fire level 2.
                    damage = 2; //sets the damage to enemies to be 2.
                    break;
                case 2: //if the power level is 2
                    fireImage = fire_level3_img; //sets fire image to be fire level 3.
                    damage = 3;  //sets the damage to enemies to be 3.
                    break;
                default: //in default
                    fireImage = fire_level1_img; //sets fire image to be fire level 1.
                    damage = 1;  //sets the damage to enemies to be 1.
                    break;
            }

            //Sets duration for power up condition.
            PowerUpDurationTimer.Start();
        }
       

        //Sets game over.
        private void GameOver()
        {
            //stops main battle theme music.
            mainTheme.Ctlcontrols.stop();

            //plays game over music.
            gameOverMusic.Ctlcontrols.play();

            //stops all objects moving.
            BackgroundMoveSpeed.Stop(); //stops background star movements.
            ItemSpawnTimer.Stop(); //stops spawning items.
            ItemMoveTimer.Stop(); //stops item movements.
            EnemySpawnTimer.Stop(); //stops spawning enemies.
            EnemyMoveTimer.Stop(); //stops enemies moving.
            //Stops all enemies' munitions movements.
            for (int e = enemies.Count - 1; e >= 0; e--)
            {
                Enemy enemy = enemies[e];
                enemy.StopShooting();
            }

            //shows replay button.
            replay_btn.Visible = true;
            exit_btn.Visible = true;

            //Shows game over label.
            gameover_label.Visible = true;

            //Shows final score label.
            final_score_label.Text = "Score: " + score;
            final_score_label.Visible = true;
            
        }

        //Resets current speed level to be 0 after 5 seconds.
        private void SpeedUpDurationTimer_Tick(object sender, EventArgs e)
        {
            SpeedUpDurationTimer.Stop();
            speed_lvl = 0;
            UpdateSpeed(); //updates speed.
        }

        //Resents current power level to be 0 after 10 seconds.
        private void PowerUpDurationTimer_Tick(object sender, EventArgs e)
        {
            power_lvl = 0;
            UpdatePower(); //updates power.
            PowerUpDurationTimer.Stop();
        }

        //Replays the game when the replay button is clicked.
        private void replay_btn_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts the application.
        }

        //Exits the game when the exit button is clicked.
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exits the application.
        }

        //Setting of Enemy class
        public class Enemy
        {
            public PictureBox EnemyPictureBox { get; private set; } //This allows to access the enemy's picture box.
            public List<PictureBox> munitions { get; private set; }
            public int HP { get; set; } //Declares HP.
            public int Speed { get; set; } //moving speed.

            //Declares shooting and munition move timers.
            private Timer ShootTimer;
            private Timer MunitionMoveTimer;
            private Random rd = new Random(); // Initialize the Random object

            private Control.ControlCollection formControls; //enables to access controlling other forms.

            //Enemy class: requires image, point of location, enemy's picturebox size, and form control.
            public Enemy(Image image, Point location, Size size, Control.ControlCollection controls)
            {
                this.formControls = controls;
                //creates picturebox so as to be accessible to enemy's picture box in other part of the code.
                EnemyPictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.None,
                    Location = location,
                    Size = size
                };

                //Creates an empty munitions list.
                munitions = new List<PictureBox>();
                
                //Sets the HP and speed of enemy
                SetEnemyHpandSpeed(image);

                //enemy 1 and enemy 2 don't shoot.
                if (image != enemy1_img && image != enemy2_img)
                {
                    //Enables shooting.
                    ShootTimer = new Timer();
                    ShootTimer.Interval = rd.Next(1500, 3000); //randomly assigns interval (1.5s ~ 3s)
                    ShootTimer.Tick += EnemyMunitionSpawnTimer_Tick;
                    ShootTimer.Start();

                    //enables munitions to move.
                    MunitionMoveTimer = new Timer();
                    MunitionMoveTimer.Interval = 20;
                    MunitionMoveTimer.Tick += EnemyMunitionMoveTimer_Tick;
                }
            }

            // ****** Enemy Class Methods **********
            private void SetEnemyHpandSpeed(Image image)
            {
                //Sets HP depending on the image of the enemy.
                if (image == Form1.enemy1_img) //in case of enemy 1
                {
                    HP = 1; //Sets HP to be 1.
                    Speed = 15; //Sets its speed to be 15.
                }
                else if (image == Form1.enemy2_img) //in case of enemy 2
                {
                    HP = 2; //Sets HP to be 2.
                    Speed = 5; //Sets its speed to be 5.
                }
                else if (image == Form1.enemy3_img) //in case of enemy 3
                {
                    HP = 3; //Sets HP to be 3.
                    Speed = 4;  //Sets its speed to be 4.
                }
                else if (image == Form1.enemy4_img) //in case of enemy 4
                {
                    HP = 4; //Sets HP to be 4.
                    Speed = 2; //Sets its speed to be 2.
                }
                else //in case of enemy 5
                {
                    HP = 5; //Sets HP to be 5.
                    Speed = 2; //Sets its speed to be 2.
                }
            }

            //Spawns munitions in certain intervals that was randomly assigned above.
            private void EnemyMunitionSpawnTimer_Tick(object sender, EventArgs e)
            {
                EnemyShooting(EnemyPictureBox.Location);
                MunitionMoveTimer.Start();
            }

            //Enemy attack method. Gets each enemy's current location.
            public void EnemyShooting(Point location)
            {
                //Designs the munition.
                PictureBox enemyMunition = new PictureBox();
                enemyMunition.BorderStyle = BorderStyle.None;
                enemyMunition.Size = new Size(10, 25);
                enemyMunition.Visible = true;
                enemyMunition.BackColor = Color.Red;
                enemyMunition.Location = new Point(location.X + 37, location.Y + 5);

                //adds the munition to controls.
                this.formControls.Add(enemyMunition);
                munitions.Add(enemyMunition);
            }

            //Makes enemy munitions move.
            private void EnemyMunitionMoveTimer_Tick(object sender, EventArgs e)
            {
                for (int i = munitions.Count - 1; i >= 0; i--)
                {
                    PictureBox enemyMunition = munitions[i];
                    enemyMunition.Top += enemyMunitionSpeed; //makes the munitions move down.

                    if (enemyMunition.Top > 500) //if the munition goes over 500
                    {
                        //Removes the munition.
                        formControls.Remove(enemyMunition);
                        munitions.RemoveAt(i);
                        enemyMunition.Dispose();
                    }
                }
            }

            //Stops shooting.
            public void StopShooting()
            {
                if (ShootTimer != null && ShootTimer.Enabled)
                {
                    ShootTimer.Stop(); //stops the shooting timer (stops creating munitions).
                }
            }
        }
    }
}


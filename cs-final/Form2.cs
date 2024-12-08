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
    public partial class Form2 : Form
    {
        //Declares background image from the local file path.
        Image backgroundImage = Image.FromFile(@"assets\startmenu-background.png");

        public Form2()
        {
            //initializes components of Form 2.
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            //Sets the background image.
            this.BackgroundImage = backgroundImage;
            //Makes the image fit to the form.
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            //initializes start menu music
            startMenuMusic.URL = @"sounds\musics\start-menu-music.mp3";
            //Plays start menu music.
            startMenuMusic.Ctlcontrols.play();
        }

        //When the Start Game button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gameScreen = new Form1();
            gameScreen.Show(); //shows Form 1 (stars the game).
            this.Hide(); //hide this form.
            startMenuMusic.Ctlcontrols.stop();
        }
    }
}

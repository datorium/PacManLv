using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacManSimple
{
    public partial class Game : Form
    {
        private int heroStep = 5;
        int verVelocity = 0;
        int horVelocity = 0;
        int heroImageCount = 1;
        string heroDirection = "right";

        public Game()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            this.BackColor = Color.Blue;
            Hero.BackColor = Color.Transparent;
            Food.BackColor = Color.Green;
            Enemy.BackColor = Color.Red;
            //starging timers
            TimerHeroMove.Start();
            TimerHeroAnimate.Start();
        }

        private void HeroBorderCollision()
        {
            if(Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
            }
            else if(Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
            }
            if (Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
            }
            else if (Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.Up)
            {
                verVelocity = -heroStep;
                horVelocity = 0;
                heroDirection = "up";
            }
            else if(e.KeyCode == Keys.Down)
            {
                verVelocity = heroStep;
                horVelocity = 0;
                heroDirection = "down";
            }
            else if(e.KeyCode == Keys.Left)
            {
                verVelocity = 0;
                horVelocity = -heroStep;
                heroDirection = "left";
            }
            else if(e.KeyCode == Keys.Right)
            {
                verVelocity = 0;
                horVelocity = heroStep;
                heroDirection = "right";
            }
            
        }

        private void TimerHeroMove_Tick(object sender, EventArgs e)
        {
            Hero.Top += verVelocity;
            Hero.Left += horVelocity;
            HeroBorderCollision();
        }

        private void TimerHeroAnimate_Tick(object sender, EventArgs e)
        {
            string heroImageName;
            heroImageName = "pacman_" + heroDirection + "_" + heroImageCount;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(heroImageName);
            heroImageCount += 1;
            if(heroImageCount > 4)
            {
                heroImageCount = 1;
            }
        }
    }
}

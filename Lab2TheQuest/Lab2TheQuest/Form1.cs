using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2TheQuest
{
    public partial class Form1 : Form
    {
        private Game fGame;

        public Form1()
        {
            InitializeComponent();

            var boundaries = new Rectangle(78, 57, 420, 155);
            fGame = new Game(boundaries);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            UpdatePlayer();
            UpdateEnemies();
        }

        private void UpdateEnemies()
        {
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (var enemy in this.fGame.Enemies)
            {
                if (enemy is Bat)
                {
                    this.fGame.Bat.Location = enemy.Location;
                    this.LblBatHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }

            foreach (var enemy in this.fGame.Enemies)
            {
                if (enemy is Ghost)
                {
                    this.fGame.Ghost.Location = enemy.Location;
                    this.LblGhostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
            }

            foreach (var enemy in this.fGame.Enemies)
            {
                if (enemy is Ghoul)
                {
                    this.fGame.Ghoul.Location = enemy.Location;
                    this.LblGhoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            PicBoxBat.Location = fGame.Bat.Location;
            PicBoxGhost.Location = fGame.Ghost.Location;
            PicBoxGhoul.Location = fGame.Ghoul.Location;
            
            if (showBat)
                this.PicBoxBat.Visible = true;
            if (showGhost)
                this.PicBoxGhost.Visible = true;
            if (showGhoul)
                this.PicBoxGhoul.Visible = true;

            LblBatHitPoints.Text = fGame.Bat.HitPoints.ToString();
            LblGhostHitPoints.Text = fGame.Ghost.HitPoints.ToString();
            LblGhoulHitPoints.Text = fGame.Ghoul.HitPoints.ToString();
        }

        private void UpdatePlayer()
        {
            this.PicBoxPlayer.Location = this.fGame.PlayerLocation;
            this.PicBoxPlayer.Visible = true;
            this.LblPlayerHitPoints.Text = this.fGame.PlayerHitPoints.ToString();
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            fGame.MoveAllObjects(Game.Direction.Right);
            UpdateCharacters();
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            fGame.MoveAllObjects(Game.Direction.Down);
            UpdateCharacters();
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            fGame.MoveAllObjects(Game.Direction.Left);
            UpdateCharacters();
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            fGame.MoveAllObjects(Game.Direction.Up);
            UpdateCharacters();
        }
    }
}

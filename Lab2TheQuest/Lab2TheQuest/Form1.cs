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
        private PictureBox fPicBoxWeaponInRoom;
        private List<PictureBox> fPicBoxesWeapons;

        public Form1()
        {
            InitializeComponent();

            var boundaries = new Rectangle(78, 57, 420, 155);
            fGame = new Game(boundaries);
            fPicBoxesWeapons = new List<PictureBox>() { PicBoxBow, PicBoxPotionBlue, PicBoxSword, PicBoxMace, PicBoxPotionRed };
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            UpdatePlayer();
            UpdateWeapons();
            UpdateEnemies();
        }

        private void UpdateEnemies()
        {
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (var enemy in fGame.Enemies)
            {
                if (enemy is Bat)
                {
                    fGame.Bat.Location = enemy.Location;
                    LblBatHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }

            foreach (var enemy in fGame.Enemies)
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

            foreach (var enemy in fGame.Enemies)
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

            if (!(fGame.Bat == null)) PicBoxBat.Location = fGame.Bat.Location;
            if (!(fGame.Ghost == null)) PicBoxGhost.Location = fGame.Ghost.Location;
            if (!(fGame.Ghoul == null)) PicBoxGhoul.Location = fGame.Ghoul.Location;
            
            if (showBat)
                this.PicBoxBat.Visible = true;
            if (showGhost)
                this.PicBoxGhost.Visible = true;
            if (showGhoul)
                this.PicBoxGhoul.Visible = true;

            if (!(fGame.Bat == null)) LblBatHitPoints.Text = fGame.Bat.HitPoints.ToString();
            if (!(fGame.Ghost == null)) LblGhostHitPoints.Text = fGame.Ghost.HitPoints.ToString();
            if (!(fGame.Ghoul == null)) LblGhoulHitPoints.Text = fGame.Ghoul.HitPoints.ToString();
        }

        private void UpdatePlayer()
        {
            PicBoxPlayer.Location = fGame.PlayerLocation;
            PicBoxPlayer.Visible = true;
            LblPlayerHitPoints.Text = fGame.PlayerHitPoints.ToString();
        }

        private void UpdateWeapons()
        {
            if (fGame.WeaponInRoom is Sword) fPicBoxWeaponInRoom = PicBoxSword;

            foreach (PictureBox pbox in fPicBoxesWeapons)
                pbox.Visible = false;

            if (fGame.WeaponInRoom.IsPickedUp)
                fPicBoxWeaponInRoom.Visible = true;
        }

        #region Move Buttons
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
        #endregion
    }
}

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

            Rectangle tempRect = new Rectangle(76, 57, 449, 187);
            fGame = new Game(tempRect);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            PicBoxPlayer.Location = fGame.PlayerLocation;
            PicBoxPlayer.Visible = true;
        }
    }
}

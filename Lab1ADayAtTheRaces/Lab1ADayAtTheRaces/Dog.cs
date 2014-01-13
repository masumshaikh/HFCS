using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1ADayAtTheRaces
{
    public class Dog
    {
        private const int StartingPosX = 35;
        private const int MaxSpeed = 4;
        private const int TrackLength = 490;
        
        private static Random Randomizer = new Random();
        private int fIndex;

        public Dog(PictureBox picBox, int index)
        {
            MyPictureBox = picBox;
            Index = index;
            ReadyGetSet();
        }

        private int StartingPosY { get; set; }
        private PictureBox MyPictureBox { get; set; }

        public int Index
        {
            get
            {
                return fIndex;
            }
            private set
            {
                fIndex = value;
                StartingPosY = 20 + fIndex * 50;
            }
        }

        public void ReadyGetSet()
        {
            var p = MyPictureBox.Location;
            p.X = StartingPosX;
            p.Y = StartingPosY;
            MyPictureBox.Location = p;
        }

        public bool RunOnePaceAndCheckIfWon()
        {
            var p = MyPictureBox.Location;
            p.X += Randomizer.Next(MaxSpeed);
            MyPictureBox.Location = p;

            return p.X >= TrackLength;
        }
    }
}

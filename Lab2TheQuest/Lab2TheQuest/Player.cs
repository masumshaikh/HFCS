using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Player
    {
        public Player(Point initLocation)
        {
            Point tempPoint = new Point();
            tempPoint.X = initLocation.X;
            tempPoint.Y = initLocation.Y;

            WhereAmI = tempPoint;
        }
        
        public Point WhereAmI { get; set; }
        public int HitPoints { get; set; }
        public List<Game.WeaponName> Weapons { get; set; }

        public void Move(Game.Direction playerMoveDirection)
        {
        }

        internal void Equip(Game.WeaponName weapon)
        {
            throw new NotImplementedException();
        }

        internal void Hit(int maxDamage, Random random)
        {
            throw new NotImplementedException();
        }

        internal void IncreaseHealth(int health, Random random)
        {
            throw new NotImplementedException();
        }

        internal void Attack(Game.Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}

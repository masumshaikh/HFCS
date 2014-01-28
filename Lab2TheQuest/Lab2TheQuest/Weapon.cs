using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Weapon : Mover
    {
        public Weapon(Point p) : base(p)
        {
        }

        public Game.WeaponName Name { get; private set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}

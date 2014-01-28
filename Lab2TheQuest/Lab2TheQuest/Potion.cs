using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public interface IPotion
    { 
    }

    public class Potion : Weapon, IPotion
    {
        public Potion(Point p)
            : base(p)
        {
        }
    }
}

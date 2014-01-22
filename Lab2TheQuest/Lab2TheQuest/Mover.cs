using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point WhereAmI;

        public Mover(Point p)
        {
            WhereAmI = p;
        }

        public Mover(Game.Direction direction, Rectangle rect)
        { 
            
        }
    }
}

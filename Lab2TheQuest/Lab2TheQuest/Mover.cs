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
        
        public Mover(Point p)
        {
            WhereAmI = p;
        }

        public Point WhereAmI { get; protected set; }
    
        public Point Move(Game.Direction direction, Rectangle boundaries)
        {
            Point newLocation = WhereAmI;
            switch (direction)
            {
                case Game.Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Game.Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Game.Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Game.Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default:
                    break;
            }

            return newLocation;
        }
    }
}

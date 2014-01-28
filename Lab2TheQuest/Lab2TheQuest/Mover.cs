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
            this.Location = p;
        }

        public Point Location { get; protected set; }
    
        public void Move(Game.Direction direction, Rectangle boundaries)
        {
            Point newLocation = this.Location;
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
            }

            this.Location = newLocation;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            return (Math.Abs(Location.X - locationToCheck.X) < distance) && (Math.Abs(Location.Y - locationToCheck.Y) < distance);
        }
    }
}

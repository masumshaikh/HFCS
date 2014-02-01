using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public abstract class Enemy : Mover
    {
        protected Enemy(Point p) : base(p)
        {
            this.Location = p;
        }

        protected Enemy(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
            int x = rnd.Next(boundaries.Left, boundaries.Right);
            int y = rnd.Next(boundaries.Top, boundaries.Bottom);
            var p = new Point(x, y);

            this.Location = p;
        }

        public int HitPoints { get; protected set; }
        protected int MaxDamage { get; set; }

        public void MoveTowardsPlayer(Rectangle boundaries, Point playerLocation)
        {
            Game.Direction direction;
            bool vertTrueHorzFalse = Math.Abs(playerLocation.Y - Location.Y) > Math.Abs(playerLocation.X - Location.X);
            
            if (vertTrueHorzFalse)
                direction = playerLocation.Y > this.Location.Y ? Game.Direction.Down : Game.Direction.Up;
            else
                direction = playerLocation.X > this.Location.X ? Game.Direction.Right : Game.Direction.Left;

            this.Move(direction, boundaries);
        }

        public void HitPlayer(Player player, Random rnd)
        {
            player.TakeHit(MaxDamage, rnd);
        }

        public void TakeHit(int damage, Random rnd)
        {
            HitPoints -= rnd.Next(1, damage);
            if (HitPoints < 0) HitPoints = 0;
        }

        public bool Nearby(Point locationToCheck, int distance, Game.Direction direction)
        {
            return true;
        }


        public abstract void Move(Random rand, Rectangle boundaries, Point playerLocation);
    }
}

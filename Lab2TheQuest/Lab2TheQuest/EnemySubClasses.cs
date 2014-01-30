using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Bat : Enemy
    {
        private const int InitHealth = 6;
        private const int MaxDamageConst = 2;

        public Bat(Point p)
            : base(p)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }

        public Bat(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }
        
        public override void Move(Random rand, Rectangle boundaries, Point playerLocation)
        {
            // only move if it has one or more hit points
            if (this.HitPoints > 0)
            {
                // move in random direction with probability 1/2
                if (rand.NextDouble() < 0.5)
                {
                    Game.Direction direction = (Game.Direction)rand.Next(3);
                    this.Move(direction, boundaries);
                }
                else
                {
                    // else move towards player. 1st decide direction.
                    this.MoveTowardsPlayer(boundaries, playerLocation);
                }
            }
        }
    }

    public class Ghost : Enemy
    {
        private const int InitHealth = 8;
        private const int MaxDamageConst = 3;

        public Ghost(Point p)
            : base(p)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }

        public Ghost(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }

        public override void Move(Random rand, Rectangle boundaries, Point playerLocation)
        {
            // only move if it has one or more hit points
            if (this.HitPoints > 0)
            {
                // move towards player with probability 1/3, else stand still
                if (rand.NextDouble() < 0.3333)
                {
                    this.MoveTowardsPlayer(boundaries, playerLocation);
                }
            }
        }
    }

    public class Ghoul : Enemy
    {
        private const int InitHealth = 10;
        private const int MaxDamageConst = 4;

        public Ghoul(Point p)
            : base(p)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }

        public Ghoul(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
            HitPoints = InitHealth;
            MaxDamage = MaxDamageConst;
        }

        public override void Move(Random rand, Rectangle boundaries, Point playerLocation)
        {
            // only move if it has one or more hit points
            if (this.HitPoints > 0)
            {
                // move towards player with probability 1/3, else stand still
                if (rand.NextDouble() < 0.66667)
                {
                    this.MoveTowardsPlayer(boundaries, playerLocation);
                }
            }
        }
    }
}

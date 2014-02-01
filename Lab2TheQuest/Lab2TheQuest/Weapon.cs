using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public interface IPotion
    {
        bool IsUsed { get; }
    }

    public abstract class Weapon : Mover
    {
        protected Weapon(Point p) : base(p)
        {
            IsPickedUp = false;
        }

        protected Weapon(Rectangle boundaries, Random rnd) : base(boundaries, rnd)
        {
            IsPickedUp = false;
        }

        public virtual Game.WeaponName Name { get; private set; }
        public bool IsPickedUp { get; private set; }

        public void BePickedUp()
        {
            IsPickedUp = true;
        }

        protected bool DamageEnemy(Game game, Point playerLocation,
                                    Game.Direction direction, int distance, int damage, 
                                    Random rnd)
        {
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy.Nearby(playerLocation, distance, direction))
                    enemy.TakeHit(damage, rnd);
                    return true;
            }

            game.MovePlayer(direction);
            return false;
        }

        public abstract void Attack(Game.Direction direction, Random rnd);
    }
}

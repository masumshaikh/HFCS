using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Player : Mover
    {
        private const int InitHealth = 10;

        private Weapon fEquippedWeapon;
        private List<Weapon> fInventory;
        
        public Player(Point p) : base(p)
        {
            HitPoints = InitHealth;
        }

        public int HitPoints { get; private set; }
        public List<Game.WeaponName> InventoryWeaponNames { get; private set; }

        internal void Equip(Game.WeaponName weaponName)
        {
            foreach (Weapon w in fInventory)
            {
                if (w.Name == weaponName) fEquippedWeapon = w;
            }
        }

        internal void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        internal void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        internal void Attack(Game.Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}

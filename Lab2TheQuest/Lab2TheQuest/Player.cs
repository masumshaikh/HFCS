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

        public List<Weapon> Inventory
        {
            get
            {
                return fInventory;
            }
            private set
            {
                fInventory = value;
                foreach (Weapon weapon in Inventory)
                {
                    if (!InventoryWeaponNames.Any(wN => wN == weapon.Name))
                        InventoryWeaponNames.Add(weapon.Name);
                }
            }
        }
        
        public void Equip(Game.WeaponName weaponName)
        {
            foreach (Weapon w in this.Inventory)
            {
                if (w.Name == weaponName) fEquippedWeapon = w;
            }
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Attack(Game.Direction direction, Random random)
        {
            if (fEquippedWeapon == null)
                return;
            else
            {
                fEquippedWeapon.Attack();
                if (fEquippedWeapon is IPotion)
                    // might to make sure some gui stuff gets done after this.
                    fEquippedWeapon = null;

            }
        }

        public void PickUpWeapon(Weapon weaponToPickUp)
        {
            this.Inventory.Add(weaponToPickUp);
            if (Inventory.Count == 1)
                this.Equip(weaponToPickUp.Name);
        }
    }
}

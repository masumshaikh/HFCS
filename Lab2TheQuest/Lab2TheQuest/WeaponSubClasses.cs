using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Sword : Weapon
    {
        protected Sword(Point p) : base(p)
        {
        }

        public Sword(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
        }
        
        public override Game.WeaponName Name
        {
            get { return Game.WeaponName.Sword; }
        }

        public override void Attack(Game.Direction direction, Random rnd)
        {
            throw new NotImplementedException();
        }
    }

    public class PotionBlue : Weapon, IPotion
    {
        protected PotionBlue(Point p)
            : base(p)
        {
        }

        public PotionBlue(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
        }

        public bool IsUsed { get; set; }

        public override Game.WeaponName Name
        {
            get { return Game.WeaponName.PotionBlue; }
        }

        public override void Attack(Game.Direction direction, Random rnd)
        {
            throw new NotImplementedException();
        }
    }

    public class PotionRed : Weapon, IPotion
    {
        protected PotionRed(Point p)
            : base(p)
        {
        }

        public PotionRed(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
        }

        public bool IsUsed { get; private set; }

        public override Game.WeaponName Name
        {
            get { return Game.WeaponName.PotionRed; }
        }

        public override void Attack(Game.Direction direction, Random rnd)
        {
            throw new NotImplementedException();
        }
    }

    public class Bow : Weapon
    {
        protected Bow(Point p)
            : base(p)
        {
        }

        public Bow(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
        }

        public bool IsUsed { get; private set; }

        public override Game.WeaponName Name
        {
            get { return Game.WeaponName.Bow; }
        }

        public override void Attack(Game.Direction direction, Random rnd)
        {
            throw new NotImplementedException();
        }
    }

    public class Mace : Weapon
    {
        protected Mace(Point p)
            : base(p)
        {
        }

        public Mace(Rectangle boundaries, Random rnd)
            : base(boundaries, rnd)
        {
        }

        public bool IsUsed { get; private set; }

        public override Game.WeaponName Name
        {
            get { return Game.WeaponName.Mace; }
        }

        public override void Attack(Game.Direction direction, Random rnd)
        {
            throw new NotImplementedException();
        }
    }
}

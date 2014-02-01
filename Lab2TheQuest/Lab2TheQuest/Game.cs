using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lab2TheQuest
{
    public class Game
    {
        private Player fPlayer;
        private List<Enemy> fEnemies;
        private Random fRandom = new Random();
        
        public Game(Rectangle boundaries)
        {
            Boundaries = boundaries;
            fPlayer = new Player(new Point(boundaries.Left + 10, boundaries.Top + 70));

            Bat = new Bat(boundaries, fRandom);
            Ghost = new Ghost(boundaries, fRandom);
            Ghoul = new Ghoul(boundaries, fRandom);
            fEnemies = new List<Enemy> { Bat, Ghost, Ghoul };
            Enemies = fEnemies;

            var Sword = new Sword(boundaries, fRandom);
            WeaponInRoom = Sword;
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
        }

        public enum WeaponName
        {
            Sword,
            BluePotion,
            Bow,
            RedPotion,
            Mace,
        }

        public Point PlayerLocation { get { return fPlayer.Location; } }
        public int PlayerHitPoints { get { return fPlayer.HitPoints; } }
        public Rectangle Boundaries { get; private set; }
        public List<Enemy> Enemies { get; private set; }
        public Bat Bat { get; set; }
        public Ghost Ghost { get; set; }
        public Ghoul Ghoul { get; set; }
        public Weapon WeaponInRoom { get; set; }

        public void MovePlayer(Direction playerMoveDirection)
        {
            fPlayer.Move(playerMoveDirection, Boundaries);
        }

        public void MoveAllObjects(Direction playerMoveDirection)
        {
            MovePlayer(playerMoveDirection);

            if (fPlayer.Nearby(WeaponInRoom.Location, 10))
                fPlayer.PickUpWeapon(WeaponInRoom);

            foreach (var enemy in fEnemies)
            {
                enemy.Move(fRandom, Boundaries, PlayerLocation);
                if (enemy.Nearby(fPlayer.Location, 10))
                    enemy.HitPlayer(fPlayer, fRandom);
            }
        }

        public void Equip(WeaponName weapon)
        {
            fPlayer.Equip(weapon);
        }

        public bool CheckPlayerInventory(WeaponName weapon)
        {
            return fPlayer.InventoryWeaponNames.Contains(weapon);
        }

        public void IncreasePlayerHealth(int health)
        {
            fPlayer.IncreaseHealth(health, fRandom);
        }
        
        public void Attack(Direction direction)
        {
            fPlayer.Attack(direction, fRandom);
            foreach (Enemy enemy in fEnemies)
                enemy.Move(fRandom, Boundaries, PlayerLocation);
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point
                (
                   Boundaries.Left + random.Next(Boundaries.Right / 10 - Boundaries.Left / 10) * 10,
                   Boundaries.Top + random.Next(Boundaries.Bottom / 10 - Boundaries.Top / 10) * 10 );
        }
    }
}

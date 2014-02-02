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
        private int fLevel = 0;
        
        public Game(Rectangle boundaries)
        {
            Boundaries = boundaries;
            fPlayer = new Player(new Point(boundaries.Left + 10, boundaries.Top + 70));

            NewLevel();
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
            PotionBlue,
            Bow,
            PotionRed,
            Mace,
        }

        public Point PlayerLocation { get { return fPlayer.Location; } }
        public int PlayerHitPoints { get { return fPlayer.HitPoints; } }
        public Rectangle Boundaries { get; private set; }
        public List<Enemy> Enemies { get; private set; }
        public Bat Bat { get; private set; }
        public Ghost Ghost { get; private set; }
        public Ghoul Ghoul { get; private set; }
        public Weapon WeaponInRoom { get; private set; }

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

        public void NewLevel()
        {
            fLevel++;
            switch (fLevel)
            {
                case 1:
                    Bat = new Bat(this.Boundaries, fRandom);
                    fEnemies = new List<Enemy> { Bat };
                    Enemies = fEnemies;

                    var Sword = new Sword(this.Boundaries, fRandom);
                    WeaponInRoom = Sword;
                    break;

                case 2:
                    Ghost = new Ghost(this.Boundaries, fRandom);
                    fEnemies = new List<Enemy> { Ghost };
                    Enemies = fEnemies;

                    var PotionBlue = new PotionBlue(this.Boundaries, fRandom);
                    WeaponInRoom = PotionBlue;
                    break;

                case 3:
                    Bat = new Bat(this.Boundaries, fRandom);
                    Ghost = new Ghost(this.Boundaries, fRandom);
                    fEnemies = new List<Enemy> { Bat, Ghost };
                    Enemies = fEnemies;

                    break;

            }
        }
    }
}

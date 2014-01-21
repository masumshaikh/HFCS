using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2TheQuest
{
    public class Game
    {
        private Player fPlayer = new Player();
        private List<Enemy> fEnemies = new List<Enemy>();
        private Random fRandom = new Random();

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
        }

        public void Move(Direction playerMoveDirection)
        {
            fPlayer.Move(playerMoveDirection);
            foreach (var enemy in fEnemies)
            {
                enemy.Move();
            }
        }
    }
}

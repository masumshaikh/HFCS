using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class Game
    {
        private readonly int fMaxMoves = 10;
        private Opponent fOpponent;
        private int fNumMoves;

        public Game()
        {
            House = new House();
            fOpponent = new Opponent(House.LivingRoom);
            NumMoves = 0;
            GameStatus = GameStatusEnum.InitialStatus;
        }

        public enum GameStatusEnum
        {
            InitialStatus,
            GameStarted,
            GameOverPlayerLost,
            GameOverPlayerWon,
        }
        
        public House House { get; set; }
        public GameStatusEnum GameStatus { get; set; }

        public int NumMoves
        {
            get
            {
                return fNumMoves;
            }

            set
            {
                fNumMoves = value;
                if (fNumMoves == 10)
                    GameStatus = GameStatusEnum.GameOverPlayerLost;
            }
        }
        

        public string GameStatusString
        {
            get
            {
                switch (GameStatus)
                {
                    case GameStatusEnum.InitialStatus:
                        return "Press HIDE to begin.";
                    case GameStatusEnum.GameStarted:
                        return "You have " + (fMaxMoves - NumMoves) + " moves left.";
                    case GameStatusEnum.GameOverPlayerWon:
                        return "You found me in " + NumMoves + " moves!\n\rPress HIDE to begin.";
                    case GameStatusEnum.GameOverPlayerLost:
                        return "You didn't find me!\n\rI was in the " + fOpponent.HidingPlace + "!!\n\rPress HIDE to begin.";
                }

                return "Woops unitialized game status string :-(";
            }
        }
        
        public void StartGame()
        {
            GameStatus = GameStatusEnum.GameStarted;
            NumMoves = 0;
            for (int i = 1; i < 10; i++)
                fOpponent.Move();
        }

        public bool CheckRoomAndUpdateGameStatus()
        {
            bool temp = fOpponent.CheckAmIHidingHere(House.CurrentLocation);
            if (temp)
                GameStatus = GameStatusEnum.GameOverPlayerWon;

            return temp;
        }
    }
}

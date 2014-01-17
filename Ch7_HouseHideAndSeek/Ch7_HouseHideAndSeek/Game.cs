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
        
        public Game()
        {
            House = new House();
            fOpponent = new Opponent(House.LivingRoom);
            NumMoves = 0;
            GameStarted = false;
        }

        public House House { get; set; }
        public int NumMoves { get; set; } // todo can make private?
        
        public bool IsOpponentFound
        {
            get { return fOpponent.CheckAmIHidingHere(House.CurrentLocation); } 
        }

        public bool GameStarted { get; private set; }

        public bool GameOver
        {
            get
            { return GameStarted && (IsOpponentFound || NumMoves == fMaxMoves); }
        }

        public string GameStatus
        {
            get
            {
                if (!GameStarted)
                    return "Press Hide to begin.";

                else
                {
                    if (GameOver)
                        return IsOpponentFound ? "You found me in " + NumMoves + "moves :-(" : "You didn't find me - I win!";
                    else
                        return "You have " + (fMaxMoves - NumMoves) + " moves left.";
                }
            }
        }
        
        public void MoveOpponent()
        {
            fOpponent.Move();
            NumMoves++;
        }

        public void StartGame()
        {
            GameStarted = true;
            NumMoves = 0;
            //for (int i = 1; i < 10; i++)
            //    MoveOpponent();
        }
    }
}

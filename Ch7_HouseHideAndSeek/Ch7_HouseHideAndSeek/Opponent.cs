using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class Opponent
    {
        private Location fHidingPlace;
        private Random fRandom = new Random();

        public Opponent(Location startLocation)
        {
            this.fHidingPlace = startLocation;
        }

        public Location HidingPlace
        {
            get { return this.fHidingPlace; }
        }

        public void Move()
        {
            // If there's a door go through it with probability 1/2.
            if (this.fHidingPlace is IHazExteriorDoor)
            {
                if (fRandom.Next(2) == 1)
                    this.fHidingPlace = (this.fHidingPlace as IHazExteriorDoor).DoorLeadsTo;
            }

            // Now choose one of the exits at random and go through it.
            int numExits = this.fHidingPlace.Exits.Length;
            this.fHidingPlace = this.fHidingPlace.Exits[fRandom.Next(numExits)];

            // If there's no hiding place here, Move() again, else hide.
            if (!(this.fHidingPlace is IHazHidingPlace))
                Move();
        }

        public bool CheckAmIHidingHere(Location location)
        {
            return location == this.fHidingPlace;
        }
    }
}

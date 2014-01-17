using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class Opponent
    {
        private Location fLocation;
        private Random fRandom = new Random();

        public Opponent(Location startLocation)
        {
            fLocation = startLocation;
        }

        public void Move()
        {
            // If there's a door go through it with probability 1/2.
            if (fLocation is IHazExteriorDoor)
            {
                if (fRandom.Next(2) == 1)
                    fLocation = (fLocation as IHazExteriorDoor).DoorLeadsTo;
            }

            // Now choose one of the exits at random and go through it.
            int numExits = fLocation.Exits.Length;
            fLocation = fLocation.Exits[numExits];

            // If there's no hiding place here, Move() again, else hide.
            if (!(fLocation is IHazHidingPlace))
                Move();
        }

        public bool CheckAmIHidingHere(Location location)
        {
            return location == fLocation;
        }
    }
}

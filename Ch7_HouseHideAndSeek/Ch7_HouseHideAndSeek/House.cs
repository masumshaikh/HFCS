using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class House
    {
        private readonly Outside fGarden = new Outside("garden", false);
        private readonly Room fDiningRoom = new Room("Dining Room", "a crystal chandelier");
        private readonly RoomWithDoor fLivingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
        private readonly RoomWithDoor fKitchen = new RoomWithDoor("Kitchen", "baroque tiles", "a screen door");
        private readonly OutsideWithDoor fFrontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
        private readonly OutsideWithDoor fBackYard = new OutsideWithDoor("Back Yard", true, "a screen door");

        public House()
        {
            this.fFrontYard.DoorLeadsTo = this.fLivingRoom;
            this.fFrontYard.Exits = new Location[] { this.fBackYard, this.fGarden };

            this.fBackYard.DoorLeadsTo = this.fKitchen;
            this.fBackYard.Exits = new Location[] { this.fFrontYard, this.fGarden };

            this.fLivingRoom.DoorLeadsTo = this.fFrontYard;
            this.fLivingRoom.Exits = new Location[] { this.fDiningRoom };

            this.fKitchen.DoorLeadsTo = this.fBackYard;
            this.fKitchen.Exits = new Location[] { this.fDiningRoom };

            this.fGarden.Exits = new Location[] { this.fFrontYard, this.fBackYard };
            this.fDiningRoom.Exits = new Location[] { this.fLivingRoom, this.fKitchen };

            CurrentLocation = Garden;
        }

        #region Property definitions exposing private location fields
        public Outside Garden
        {
            get { return fGarden; }
        }

        public Room DiningRoom
        {
            get { return fDiningRoom; }
        }

        public RoomWithDoor LivingRoom
        {
            get { return fLivingRoom; }
        }

        public RoomWithDoor Kitchen
        {
            get { return fKitchen; }
        }

        public OutsideWithDoor FrontYard
        {
            get { return fFrontYard; }
        }

        public OutsideWithDoor BackYard
        {
            get { return fBackYard; }
        }
        #endregion

        public Location CurrentLocation { get; set; }

        public bool CanSeeDoorFrom(Location from)
        {
            return from is IHasExteriorDoor;
        }

        public bool TryMoveToANewLocation(Location from, Location to)
        {
            if (from.Exits.Contains(to) || (from as IHasExteriorDoor).DoorLeadsTo == to)
            {
                CurrentLocation = to;
                return true;
            }
            else
                return false;
        }
    }
}

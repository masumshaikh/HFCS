using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class House
    {
        private readonly Room fDiningRoom = new Room("Dining Room", "a crystal chandelier");
        private readonly RoomWithHidingPlaceAndDoor fLivingRoom = new RoomWithHidingPlaceAndDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass knob");
        private readonly RoomWithHidingPlaceAndDoor fKitchen = new RoomWithHidingPlaceAndDoor("Kitchen", "baroque tiles", "in the cabinet", "a screen door");
        private readonly OutsideWithDoor fFrontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
        private readonly OutsideWithDoor fBackYard = new OutsideWithDoor("Back Yard", true, "a screen door");

        private readonly Room fStairs = new Room("Stairs", "a wooden bannister");
        private readonly RoomWithHidingPlace fUpstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "a closet");

        private readonly RoomWithHidingPlace fMasterBedroom = new RoomWithHidingPlace("Master Bedroom", "under the bed", "a four-post bed");
        private readonly RoomWithHidingPlace fSecondBedroom = new RoomWithHidingPlace("Second Bedroom", "under the bed", "a Moroccan bed");
        private readonly RoomWithHidingPlace fBathroom = new RoomWithHidingPlace("Bathroom", "in the shower", "a sink and toilet");

        private readonly OutsideWithHidingPlace fDriveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");
        private readonly OutsideWithHidingPlace fGarden = new OutsideWithHidingPlace("Garden", false, "in the shed");

        public House()
        {
            fFrontYard.DoorLeadsTo = fLivingRoom;
            fFrontYard.Exits = new Location[] { fBackYard, fGarden, fDriveway };

            fBackYard.DoorLeadsTo = fKitchen;
            fBackYard.Exits = new Location[] { fFrontYard, fGarden, fDriveway };

            fLivingRoom.DoorLeadsTo = fFrontYard;
            fLivingRoom.Exits = new Location[] { fDiningRoom, fStairs };

            fKitchen.DoorLeadsTo = fBackYard;
            fKitchen.Exits = new Location[] { fDiningRoom };

            fGarden.Exits = new Location[] { fFrontYard, fBackYard };
            fDiningRoom.Exits = new Location[] { fLivingRoom, fKitchen };

            fStairs.Exits = new Location[] { fLivingRoom, fUpstairsHallway };
            fUpstairsHallway.Exits = new Location[] { fMasterBedroom, fSecondBedroom, fBathroom, fStairs };
            fMasterBedroom.Exits = new Location[] { fUpstairsHallway };
            fSecondBedroom.Exits = new Location[] { fUpstairsHallway };
            fBathroom.Exits = new Location[] { fUpstairsHallway };
            fDriveway.Exits = new Location[] { fFrontYard, fBackYard };

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

        public RoomWithHidingPlaceAndDoor LivingRoom
        {
            get { return fLivingRoom; }
        }

        public RoomWithHidingPlaceAndDoor Kitchen
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

        public RoomWithHidingPlace MasterBedroom
        {
            get { return fMasterBedroom; }
        }

        public RoomWithHidingPlace SecondBedroom
        {
            get { return fSecondBedroom; }
        }

        public RoomWithHidingPlace Bathroom
        {
            get { return fBathroom; }
        }

        public Room Stairs
        {
            get { return fStairs; }
        }

        public RoomWithHidingPlace UpstairsHallway
        {
            get { return fUpstairsHallway; }
        }

        public OutsideWithHidingPlace Driveway
        {
            get { return fDriveway; }
        }
        #endregion

        public Location CurrentLocation { get; set; }

        public bool CanSeeDoorFrom(Location from)
        {
            return from is IHazExteriorDoor;
        }

        public bool TryMoveToANewLocation(Location from, Location to)
        {
            if (from.Exits.Contains(to) || (from as IHazExteriorDoor).DoorLeadsTo == to)
            {
                CurrentLocation = to;
                return true;
            }
            else
                return false;
        }
    }
}

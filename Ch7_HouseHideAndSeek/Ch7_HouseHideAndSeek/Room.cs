using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_HouseHideAndSeek
{
    public class Room : Location
    {
        public Room(string name, string decoration)
            : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; private set; }

        public override string Description
        {
            get { return base.Description + string.Format(" You see {0} here.", Decoration); }
        }
    }

    public class RoomWithHidingPlace : Room, IHazHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace)
            : base(name, decoration)
        {
            HidingPlace = hidingPlace;
        }

        public string HidingPlace { get; private set; }
    }

    public class RoomWithHidingPlaceAndDoor : RoomWithHidingPlace, IHazExteriorDoor
    {
        public RoomWithHidingPlaceAndDoor(string name, string decoration, string hidingPlace, string doorDescription)
            : base(name, decoration, hidingPlace)
        {
            DoorDescription = doorDescription;
        }

        public override string Description
        {
            get
            {
                string description = base.Description;
                description += string.Format(" You see {0} here.", DoorDescription); 
                description += string.Format(" The door leads to the {0}.", DoorLeadsTo.Name);
                return description;
            }
        }

        public string DoorDescription { get; private set; }
        public Location DoorLeadsTo { get; internal set; }
    }
}

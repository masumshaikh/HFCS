using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_House
{
    public class Room : Location
    {
        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public string Decoration { get; private set; }

        public override string Description
        {
            get { return base.Description + string.Format(" You see {0} here.", Decoration); }
        }
    }

    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }

        public override string Description
        {
            get { return base.Description + string.Format(" You see {0} here.", DoorDescription); }
        }

        public string DoorDescription { get; private set; }
        public Location DoorLeadsTo { get; internal set; }
    }
}

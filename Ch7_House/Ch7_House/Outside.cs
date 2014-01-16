using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_House
{
    public class Outside : Location
    {
        public Outside(string name, bool hot) 
            : base(name)
        {
            Hot = hot;
        }
        
        public bool Hot { get; private set; }

        public override string Description
        {
            get
            {
                string description = base.Description;

                if (Hot)
                    description += " It's very hot here!";
                else
                    description += " It's not hot here.";

                return description;
            }
        }
    }

    public class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
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

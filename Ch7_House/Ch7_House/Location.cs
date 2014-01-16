using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7_House
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLeadsTo { get; }
    }

    public abstract class Location
    {
        private readonly string fName;

        protected Location(string name)
        {
            fName = name;
        }

        public Location[] Exits { get; set; }

        public virtual string Description
        {
            get
            {
                string description = string.Format("You're standing in the {0}. You see exits to the following places:", fName);

                for (int i = 0; i < Exits.Length; i++)
                {
                    description += string.Format(" {0}", Exits[i].fName);
                    if (i < Exits.Length)
                        description += ",";
                }

                description += ".";

                return description;
            }
        }

        protected string Name
        {
            get { return fName; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch8_Ducks
{
    public class Duck : IComparable<Duck>
    {
        public Duck(int size, KindOfDuck kind)
        {
            Size = size;
            Kind = kind;
        }

        public enum KindOfDuck
        {
            Mallard,
            Muscovy,
            Decoy,
        }

        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public override string ToString()
        {
            return string.Format("A {0} duck of size {1}", Kind, Size);
        }

        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            else if (this.Size < other.Size)
                return -1;
            else
                return string.CompareOrdinal(this.Kind.ToString(), other.Kind.ToString());
        }
    }

    public class Ducks : List<Duck>
    {
        public override string ToString()
        {
            string outString = string.Empty;
            var iter = this.GetEnumerator();
            while (iter.MoveNext())
            {
                outString += iter.Current.ToString() + "\n";
            }

            return outString;
        }
    }
}

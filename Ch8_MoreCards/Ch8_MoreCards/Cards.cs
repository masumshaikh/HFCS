using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch8_MoreCards
{
    public enum Suits
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades,
    }

    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public class Card : IComparable<Card>
    {
        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public Values Value { get; set; }
        public Suits Suit { get; set; }

        public override string ToString()
        {
            return string.Format("The {0} of {1}", Value, Suit);
        }

        public int CompareTo(Card other)
        {
            // Order by Value then Suit
            if ((int)this.Value > (int)other.Value)
                return 1;
            else if ((int)this.Value < (int)other.Value)
                return -1;
            else
                if ((int)this.Suit > (int)other.Suit)
                    return 1;
                else if ((int)this.Suit < (int)other.Suit)
                    return -1;
                else
                    return 0;
        }

        public bool Equals(Card other)
        {
            return (this.CompareTo(other) == 0) ? true : false;
        }
    }
}

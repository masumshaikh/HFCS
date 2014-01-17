using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch8_Cards
{
    public enum Suits
    {
        Hearts,
        Clubs,
        Diamonds,
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

    public class Card
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
    }

    public class ShowCards
    {
        private static Random fRandom = new Random();
        public static void Main()
        {
            ////MessageBox.Show(((int)Values.Ace).ToString());
            ////MessageBox.Show((Values.Ace).ToString());
            ////MessageBox.Show(((Suits)3).ToString());

            int numValues = Enum.GetNames(typeof(Values)).Length;
            int numSuits = Enum.GetNames(typeof(Suits)).Length;

            int nextValue = fRandom.Next(numValues) + 1;
            int nextSuit = fRandom.Next(numSuits);

            ///Card x = new Card((Values)nextValue, (Suits)nextSuit);
            Card x = new Card(nextValue, nextSuit);
            MessageBox.Show(x.ToString() + nextValue + ", " + nextSuit);
        }
    }
}

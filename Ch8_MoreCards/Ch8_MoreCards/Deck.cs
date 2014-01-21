using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch8_MoreCards
{
    public class Deck : List<Card>
    {
        private Random fRandom = new Random();
        private int numberOfSuits = Enum.GetNames(typeof(Suits)).Length;
        private int numberOfValues = Enum.GetNames(typeof(Values)).Length;

        public Deck()
        {
            // Construct a full deck.
            for (int suit = 0; suit < numberOfSuits; suit++)
                for (int value = 1; value <= numberOfValues; value++)
                    this.Add(new Card((Values)value, (Suits)suit));
        }

        public Deck(int n)
        {
            // construct a deck with 'n' random Cards. Where n is capped at 52
            n = Math.Min(n, numberOfSuits * numberOfValues);

            for (int i = 0; i < n; i++)
            {
                // Construct a temporary card.
                Suits tempSuit = (Suits)fRandom.Next(numberOfSuits);
                Values tempValue = 1 + (Values)fRandom.Next(numberOfValues);
                Card tempCard = new Card(tempValue, tempSuit);

                // If tempCard hasn't been added to Deck yet, then add it.
                bool exists = this.Any(c => c.Equals(tempCard));
                if (!exists)
                    this.Add(tempCard);
            }
        }

        public int NumCards
        {
            get { return this.Count; }
        }

        public override string ToString()
        {
            var iter = this.GetEnumerator();
            string outString = string.Empty;

            while (iter.MoveNext())
            {
                outString += iter.Current.ToString() + "\n";
            }

            return outString;
        }

        public void Shuffle()
        {
            for (int i = this.Count - 1; i > 0; i--)
            {
                int j = fRandom.Next(i + 1);
                Card toMove = this[j];
                this[j] = this[i];
                this[i] = toMove;
            }
        }
    }
}

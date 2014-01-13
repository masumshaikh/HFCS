using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Farmer
{
    public class Farmer
    {
        private int fFeedMultiplier = 30;
        private int fNumCows;
        
        public int NumCows
        {
            get { return fNumCows; }
            set
            {
                fNumCows = value;
                BagsOfFeed = fNumCows * FeedMultiplier;
            }
        }

        public int FeedMultiplier
        {
            get { return fFeedMultiplier; }
        }

        public int BagsOfFeed
        {
            get;
            private set;
        }

    }
}

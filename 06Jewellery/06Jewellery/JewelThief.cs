using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Jewellery
{
    class JewelThief : Locksmith
    {
        private Jewels fStolenJewels = null;

        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            fStolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + fStolenJewels.Sparkle());
        }
    }
}

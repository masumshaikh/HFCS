using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Jewellery
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string fCorrectCombination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == fCorrectCombination)
            return contents;
            else
            return null;
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(fCorrectCombination);
        }
    }
}

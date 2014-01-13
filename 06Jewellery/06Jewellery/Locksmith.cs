using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Jewellery
{
    class Locksmith
    {
        private string fWrittenDownCombination = null;
        
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(fWrittenDownCombination);
            ReturnContents(safeContents, owner);
        }

        public void WriteDownCombination(string combination)
        {
            fWrittenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}

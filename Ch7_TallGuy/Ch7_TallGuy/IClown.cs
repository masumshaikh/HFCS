using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch7_Clowns
{
    public interface IClown
    {
        string FunnyThingIHave { get; }

        void Honk();
    }

    public interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }

    public class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            FunnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave { get; private set; }

        public void Honk()
        {
            MessageBox.Show(string.Format("Honk honk! I have a {0}.", FunnyThingIHave));
        }
    }

    public class ScaryScary : FunnyFunny, IScaryClown
    {
        private int fNumScaryThings;

        public ScaryScary(string funnyThingIHave, int numScaryThings, string scaryThingIHave) : base(funnyThingIHave)
        {
            fNumScaryThings = numScaryThings;
            ScaryThingIHave = scaryThingIHave;
        }

        public string ScaryThingIHave { get; private set; }

        public void ScareLittleChildren()
        {
            MessageBox.Show(string.Format("BOO! I have {0} {1}(s)!!", fNumScaryThings, ScaryThingIHave));
        }
    }
}

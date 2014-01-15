using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch7_Clowns
{
    public class TallGuy : IClown
    {
        private readonly string fName;
        private readonly int fHeight;

        public TallGuy(string name, int height)
        {
            fName = name;
            fHeight = height;
        }

        public string FunnyThingIHave
        {
            get { return "big shoes";}
        }

        public void TalkAboutYourself()
        {
            MessageBox.Show("My name is " + fName + " and I am " + fHeight + " cm tall.");
        }

        public void Honk()
        {
            MessageBox.Show("HONK HONK!");
        }

    }
}

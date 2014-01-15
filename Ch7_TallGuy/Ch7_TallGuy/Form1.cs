using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch7_Clowns
{
    public partial class Form1 : Form
    {
        private TallGuy fJimmy = new TallGuy("Jimmy", 175);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fJimmy.Honk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fJimmy.TalkAboutYourself();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14, "spider");
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            someOtherScaryClown.ScareLittleChildren();
        }
    }
}

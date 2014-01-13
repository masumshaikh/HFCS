using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04Elephants
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant("Lloyd", 33);
        Elephant lucinda = new Elephant("Lucinda", 25);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var tempElephant = lloyd;
            lloyd = lucinda;
            lucinda = tempElephant;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Farmer
{
    public partial class Form1 : Form
    {
        private Farmer Giles = new Farmer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Giles.NumCows = (int)numericUpDown1.Value;
            Console.WriteLine("I need " + Giles.BagsOfFeed + " bags of feed.");
        }
    }
}

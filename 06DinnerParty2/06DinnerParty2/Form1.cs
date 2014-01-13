using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05DinnerParty
{
    public partial class Form1 : Form
    {
        private Party dP;

        public Form1()
        {
            InitializeComponent();
            UpdateCostDisplay();
        }

        public void UpdateCostDisplay()
        {
            dP.SetOptions(this);
            dP.NumberOfPeople = (int)UpDownNumPeople.Value;
            LabelCostDisplay.Text = "Total Cost: " + dP.TotalCost().ToString("c");
        }

        private void UpDownNumPeople_ValueChanged(object sender, EventArgs e)
        {
            UpdateCostDisplay();
        }

        private void ChkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCostDisplay();
        }

        private void ChkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCostDisplay();
        }
    }
}

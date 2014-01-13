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
        private DinnerParty dP = new DinnerParty();
        private BirthdayParty bP = new BirthdayParty();

        public Form1()
        {
            InitializeComponent();
            UpdateDinnerPartyCostDisplay();
        }

        public void UpdateDinnerPartyCostDisplay()
        {
            dP.NumberOfPeople = (int)UpDownNumPeople.Value;

            dP.SetHealthyOption(ChkBoxHealthy.Checked);
            dP.SetFancyDecorations(ChkBoxFancy.Checked);
         
            LabelDPCostDisplay.Text = "Total Cost: " + dP.TotalCost().ToString("c");
        }

        public void UpdateBirthdayPartyCostDisplay()
        {
            bP.NumberOfPeople = (int)NumUpDnBPNumPeople.Value;

            bP.SetFancyDecorations(CheckBoxBPFancy.Checked);
            bP.SetCakeWriting(TextBoxCakeWriting.Text);

            LabelBPCostDisplay.Text = "Total Cost: " + bP.TotalCost().ToString("c");
        }

        private void UpDownNumPeople_ValueChanged(object sender, EventArgs e)
        {
            UpdateDinnerPartyCostDisplay();
        }

        private void ChkBoxHealthy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDinnerPartyCostDisplay();
        }

        private void ChkBoxFancy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDinnerPartyCostDisplay();
        }

        private void TextBoxCakeWriting_TextChanged(object sender, EventArgs e)
        {
            UpdateBirthdayPartyCostDisplay();
        }

        private void NumUpDnBPNumPeople_ValueChanged(object sender, EventArgs e)
        {
            UpdateBirthdayPartyCostDisplay();
        }

        private void CheckBoxBPFancy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBirthdayPartyCostDisplay();
        }
    }
}

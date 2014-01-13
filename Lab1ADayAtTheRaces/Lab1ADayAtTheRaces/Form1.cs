using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        private const int NumBettors = 3; // todo Why does this have to be static or const?
        private Bettor fActiveBettor;
        private Bettor fJoe; 
        private Bettor fBob; 
        private Bettor fAlan;

        private Bettor[] fAllBettors = new Bettor[NumBettors];

        public Form1()
        {
            InitializeComponent();

            // Populate the minimum bet in the label
            MinimumBetLabel.Text = "Minimum Bet: " + BetAmountChooser.Minimum;

            // Initialize Bettors
            fJoe  = new Bettor("Joe",  50, JoeRadioButton,  JoeLabel);
            fBob  = new Bettor("Bob",  75, BobRadioButton,  BobLabel);
            fAlan = new Bettor("Alan", 45, AlanRadioButton, AlanLabel);

            fAllBettors[0] = fJoe; // todo Is there a better way of doing this?
            fAllBettors[1] = fBob;
            fAllBettors[2] = fAlan;

            // Redraw
            this.UpdateBettingParlour();
        }

        public void UpdateBettingParlour()
        {
            for (int i = 0; i < NumBettors; i++)
            {
                // Update his label
                fAllBettors[i].MyRadioButton.Text = fAllBettors[i].Name + ": has " + fAllBettors[i].Cash + " cash.";

                // Update ActiveBettorLabel if required
                if (fAllBettors[i].MyRadioButton.Checked)
                {
                    fActiveBettor = fAllBettors[i];
                    ActiveBettorLabel.Text = fActiveBettor.Name;
                }
            }
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateBettingParlour();
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateBettingParlour();
        }

        private void AlanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateBettingParlour();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            fActiveBettor.PlaceBet((uint)BetAmountChooser.Value, (int)DogChooser.Value);
            this.UpdateBettingParlour();
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            int winningDog = 3;
            for (int i = 0; i < NumBettors; i++)
            {
                fAllBettors[i].Collect(winningDog);
            }
            this.UpdateBettingParlour();
        }
    }
}

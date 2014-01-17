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
        private const int NumDogs = 4;

        private Bettor fActiveBettor;
        private Bettor fJoe; 
        private Bettor fBob; 
        private Bettor fAlan;
        private Bettor[] fAllBettors = new Bettor[NumBettors];

        private Dog[] fAllDogs = new Dog[NumDogs];

        public Form1()
        {
            InitializeComponent();

            // Populate the minimum bet in the label
            MinimumBetLabel.Text = "Minimum Bet: " + BetAmountChooser.Minimum;

            InitializeBettors();
            InitializeDogs();
            UpdateBettingParlour();
        }
        
        public void InitializeBettors()
        {
            fJoe = new Bettor("Joe", 50, JoeRadioButton, JoeLabel);
            fBob = new Bettor("Bob", 75, BobRadioButton, BobLabel);
            fAlan = new Bettor("Alan", 45, AlanRadioButton, AlanLabel);

            fAllBettors = new[] { fJoe, fBob, fAlan };
        }

        public void InitializeDogs()
        {
            fAllDogs[0] = new Dog(Dog0Picture, 0);
            fAllDogs[1] = new Dog(Dog1Picture, 1);
            fAllDogs[2] = new Dog(Dog2Picture, 2);
            fAllDogs[3] = new Dog(Dog3Picture, 3);
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

        public Dog RunRaceAndReturnWinningDog()
        {
            bool raceOver = false;
            
            while (!raceOver)
            {
                for (int i = 0; i < NumDogs; i++)
                {
                    raceOver = raceOver || fAllDogs[i].RunOnePaceAndCheckIfWon();
                    if (raceOver)
                        return fAllDogs[i];
                }
            }

            return null;
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBettingParlour();
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBettingParlour();
        }

        private void AlanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBettingParlour();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            int j = (int)DogChooser.Value;
            fActiveBettor.PlaceBet((uint)BetAmountChooser.Value, fAllDogs[j]);
            UpdateBettingParlour();
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            // Reset the dogs
            InitializeDogs();

            // Run the race;
            Dog winningDog = RunRaceAndReturnWinningDog();
            
            for (int i = 0; i < NumBettors; i++)
            {
                fAllBettors[i].Collect(winningDog);
            }

            UpdateBettingParlour();
        }
    }
}

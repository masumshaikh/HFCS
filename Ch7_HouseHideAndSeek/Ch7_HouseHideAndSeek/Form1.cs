using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch7_HouseHideAndSeek
{
    public partial class Form1 : Form
    {
        private Game fGame = new Game();

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            fGame.GameStatus = Game.GameStatusEnum.InitialStatus;

            // Show only HIDE button, no description, instruction for starting game
            BtnGoToLocation.Visible = false;
            CboxExits.Visible = false;
            BtnGoThroughDoor.Visible = false;
            BtnCheckHidingPlace.Visible = false;
            LblCurrentLocation.Visible = false;
            BtnHide.Visible = true;
            TxtBoxCurrLocDescription.Visible = false;
            TxtBoxGameStatus.Text = fGame.GameStatusString;
        }

        private void GetFormReadyForGame()
        {
            LblCurrentLocation.Visible = true;
            TxtBoxCurrLocDescription.Visible = true;
            BtnGoToLocation.Visible = true;
            CboxExits.Visible = true;
            BtnHide.Visible = false;
        }

        private void UpdateFormGameInProgress()
        {
            // Update text fields
            Location currentLoc = fGame.House.CurrentLocation;

            LblCurrentLocation.Text = "You are in the " + currentLoc.Name + ".";
            TxtBoxCurrLocDescription.Text = currentLoc.Description;

            // Update combo box
            CboxExits.Items.Clear();
            for (int i = 0; i < currentLoc.Exits.Length; i++)
            {
                CboxExits.Items.Add(currentLoc.Exits[i].Name);
            }

            CboxExits.SelectedIndex = 0;

            // Show or hide "go through door" button
            BtnGoThroughDoor.Visible = fGame.House.CanSeeDoorFrom(currentLoc);

            // Show or hide "check" button, update text
            BtnCheckHidingPlace.Visible = fGame.House.CurrentLocation is IHazHidingPlace;
            var tempHidingPlace = fGame.House.CurrentLocation as IHazHidingPlace;
            if (tempHidingPlace != null)
                BtnCheckHidingPlace.Text = "Check the hiding place: " + tempHidingPlace.HidingPlace;

            // Game Status
            TxtBoxGameStatus.Text = fGame.GameStatusString;
        }

        private void UpdateFormGameOver()
        {

            LblCurrentLocation.Visible = false;
            TxtBoxCurrLocDescription.Visible = false;
            BtnGoToLocation.Visible = false;
            BtnGoThroughDoor.Visible = false;
            CboxExits.Visible = false;
            BtnHide.Visible = true;
        
            // Game Status
            TxtBoxGameStatus.Text = fGame.GameStatusString;
        }

        private void UpdateForm()
        {
            if (fGame.GameStatus == Game.GameStatusEnum.GameStarted)
                UpdateFormGameInProgress();
            else
                UpdateFormGameOver();
        }

        private void BtnGoToLocation_Click(object sender, EventArgs e)
        {
            Location currentLoc = fGame.House.CurrentLocation;
            Location destination = currentLoc.Exits[CboxExits.SelectedIndex];

            // Next line will change the .CurrentLocation property of the house.
            bool managedToMove = fGame.House.TryMoveToANewLocation(currentLoc, destination);
            if (!managedToMove)
                MessageBox.Show("Couldn't move to that place from here!", "Woops!");
            
            // This line will change GameStatus to GameOverPlayerLost if NumMoves becomes equal to max moves allowed.
            fGame.NumMoves++;
            UpdateForm();
        }

        private void BtnGoThroughDoor_Click(object sender, EventArgs e)
        {
            Location currentLoc = fGame.House.CurrentLocation;
            Location destination = (currentLoc as IHazExteriorDoor).DoorLeadsTo;

            // Next line will change the .CurrentLocation property of the house.
            bool managedToMove = fGame.House.TryMoveToANewLocation(currentLoc, destination);
            if (!managedToMove)
                MessageBox.Show("Couldn't move to " + destination.Name + " from here!", "Woops!");
            
            // This line will change GameStatus to GameOverPlayerLost if NumMoves becomes equal to max moves allowed.
            fGame.NumMoves++;
            UpdateForm();
        }

        private void BtnCheckHidingPlace_Click(object sender, EventArgs e)
        {
            bool hidingHere = fGame.CheckRoomAndUpdateGameStatus();
            MessageBox.Show(hidingHere ? "yep I was here" : "try again");
            fGame.NumMoves++;
            UpdateForm();
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            fGame.StartGame();
            GetFormReadyForGame();
            UpdateForm();
        }
    }
}

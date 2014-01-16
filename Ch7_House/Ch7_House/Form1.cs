using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch7_House
{
    public partial class Form1 : Form
    {
        private House fHouse = new House();

        public Form1()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void UpdateForm()
        {
            // Update text fields
            Location currentLoc = fHouse.CurrentLocation;
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
            BtnGoThroughDoor.Visible = fHouse.CanSeeDoorFrom(currentLoc);
        }

        private void BtnGoToLocation_Click(object sender, EventArgs e)
        {
            Location currentLoc = fHouse.CurrentLocation;
            Location destination = currentLoc.Exits[CboxExits.SelectedIndex];

            // Next line will change the .CurrentLocation property of the house.
            bool managedToMove = fHouse.TryMoveToANewLocation(currentLoc, destination);
            if (!managedToMove)
                MessageBox.Show("Couldn't move to that place from here!", "Woops!");
            UpdateForm();
        }

        private void BtnGoThroughDoor_Click(object sender, EventArgs e)
        {
            Location currentLoc = fHouse.CurrentLocation ;
            Location destination = (currentLoc as IHasExteriorDoor).DoorLeadsTo;

            // Next line will change the .CurrentLocation property of the house.
            bool managedToMove = fHouse.TryMoveToANewLocation(currentLoc, destination);
            if (!managedToMove)
                MessageBox.Show("Couldn't move to " + destination.Name + " from here!", "Woops!");
            UpdateForm();
        }
    }
}

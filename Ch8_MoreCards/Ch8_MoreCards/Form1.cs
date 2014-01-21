using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch8_MoreCards
{
    public partial class Form1 : Form
    {
        private Random fRandom = new Random();
        private Deck fLeftDeck;
        private Deck fRightDeck;

        public Form1()
        {
            InitializeComponent();
            ResetDecks();
            UpdateForm();
        }

        private void ResetDecks()
        {
            ResetDecks(1);
            ResetDecks(2);
        }

        private void ResetDecks(int i)
        {
            if (i == 1)
            {
                fLeftDeck = new Deck(1 + fRandom.Next(19));
                fLeftDeck.Sort();
            }
            else if (i == 2)
            {
                fRightDeck = new Deck();
                fRightDeck.Sort();
            }
        }

        private void UpdateForm()
        {
            LiBoxLeftDeck.Items.Clear();
            foreach (Card t in fLeftDeck)
                LiBoxLeftDeck.Items.Add(t.ToString());

            LiBoxRightDeck.Items.Clear();
            foreach (Card t in fRightDeck)
            {
                LiBoxRightDeck.Items.Add(t.ToString());
            }
        }

        private void MoveCard(int pos, Deck deck1, Deck deck2)
        {
            Card cardToMove = deck1[pos];
            deck1.RemoveAt(pos);
            deck2.Add(cardToMove);
        }

        private void BtnMoveLeftToRight_Click(object sender, EventArgs e)
        {
            if (LiBoxLeftDeck.SelectedItems.Count > 0)
            {
                MoveCard(LiBoxLeftDeck.SelectedIndex, fLeftDeck, fRightDeck);
                UpdateForm();
            }
        }

        private void BtnMoveRightToLeft_Click(object sender, EventArgs e)
        {
            if (LiBoxRightDeck.SelectedItems.Count > 0)
            {
                MoveCard(LiBoxRightDeck.SelectedIndex, fRightDeck, fLeftDeck);
                UpdateForm();
            }
        }

        private void BtnResetDeck1_Click(object sender, EventArgs e)
        {
            ResetDecks(1);
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetDecks(2);
            UpdateForm();
        }

        private void BtnShuffleDeck1_Click(object sender, EventArgs e)
        {
            fLeftDeck.Shuffle();
            UpdateForm();
        }

        private void BtnShuffleDeck2_Click(object sender, EventArgs e)
        {
            fRightDeck.Shuffle();
            UpdateForm();
        }
    }
}

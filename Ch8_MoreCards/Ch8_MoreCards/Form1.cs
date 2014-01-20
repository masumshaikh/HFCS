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
            fLeftDeck = new Deck(1 + fRandom.Next(19));
            fRightDeck = new Deck();
            fLeftDeck.Sort();

            for (int i = 0; i < fLeftDeck.Count; i++)
                listBox1.Items.Add(fLeftDeck[i]);
        }
    }
}

using System.Windows.Forms;

namespace Lab1ADayAtTheRaces
{
    public class Bettor
    {
        private bool fHasPlacedBet = false;

        public Bettor(string name, uint cash, RadioButton btn, Label lbl)
        {
            Name = name;
            Cash = cash;
            MyRadioButton = btn;
            MyLabel = lbl;
            MyBet = new Bet();
        }

        public string Name { get; set; }
        public uint Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }
        private Bet MyBet { get; set; }

        public void PlaceBet(uint amt, Dog dog)
        {
            if (!fHasPlacedBet)
            {
                MyBet = new Bet(amt, dog); // todo what is actually happening here in terms of destructors, given line 15 in constructor?
                if (Cash >= MyBet.Amount)
                {
                    Cash -= MyBet.Amount;
                    MyLabel.Text = Name + "'s bet: " + MyBet.Amount + " on dog " + MyBet.Dog.Index;
                    fHasPlacedBet = true;
                }
                else
                    MessageBox.Show(Name + " doesn't have enough cash.");
            }
            else
                MessageBox.Show(Name + " has already placed a bet.");
        }

        public void Collect(Dog winningDog)
        {
            Cash += MyBet.PayOut(winningDog);
            MyLabel.Text = Name + "'s bet: ";
            fHasPlacedBet = false;
            MyBet = new Bet(); // todo same question as line 28
        }
    }
}

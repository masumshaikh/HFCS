using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05DinnerParty
{
    public class BirthdayParty : Party
    {
        private const decimal CostOfWritingPerLetter = 0.25M;

        private string fCakeWriting;
        private int fCakeSize;
        private int fCakeCost;
        private int fCakeMaxLetters;

        public override int NumberOfPeople
        {
            get
            {
                return base.NumberOfPeople;
            }
            set
            {
                base.NumberOfPeople = value;
                fCakeSize = NumberOfPeople <= 4 ? 8 : 16;
                fCakeCost = NumberOfPeople <= 4 ? 40: 75;
                fCakeMaxLetters = NumberOfPeople <= 4 ? 16 : 40;
            }
        }

        public void SetCakeWriting(string cakeWriting)
        {
            if (cakeWriting.Length <= fCakeMaxLetters)
                fCakeWriting = cakeWriting;
            else
                MessageBox.Show("That writing is too long!");
            
        }

        public decimal CostOfCakeAndWriting()
        {
            decimal sum = fCakeCost;
            int actualNumLetters = fCakeWriting.Count(c => !Char.IsWhiteSpace(c));
            sum += actualNumLetters * CostOfWritingPerLetter;
            return sum;
        }

        public override decimal TotalCost()
        {
            decimal sum = CostOfFood() + CostOfCakeAndWriting() + CostOfDecorations();
            if (NumberOfPeople == 0)
                sum = 0;

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return NumberOfPeople;
            }
            set
            {
                NumberOfPeople = value;
                fCakeSize = NumberOfPeople <= 4 ? 8 : 16;
                fCakeCost = NumberOfPeople <= 4 ? 40: 75;
                fCakeMaxLetters = NumberOfPeople <= 4 ? 16 : 40;
            }
        }

        private void SetCakeWriting(string cakeWriting)
        {
            fCakeWriting = cakeWriting;
        }

        public decimal CostOfCakeWriting()
        {
            decimal sum = fCakeCost;
            sum += fCakeWriting.Length * CostOfWritingPerLetter;
            return sum;
        }

        public override decimal TotalCost()
        {
            decimal sum = CostOfFood() + CostOfDecorations();
            if (NumberOfPeople == 0)
                sum = 0;

            return sum;
        }
    }
}

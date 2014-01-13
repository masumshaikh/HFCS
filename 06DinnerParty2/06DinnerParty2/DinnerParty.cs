using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DinnerParty
{
    public class DinnerParty
    {
        private const decimal FoodChargePerPerson = 25.0M;
        private const decimal CostOfAlcPerPerson = 20.0M;
        private const decimal CostOfSodaPerPerson = 5.0M;
        private const double HealthyDiscount = 0.95;
        private const decimal CostOfFancyDecPerPerson = 15.0M;
        private const decimal CostOfNormalDecPerPerson = 7.50M;
        private const decimal FlatFeeFancyDec = 50.0M;
        private const decimal FlatFeeNormalDec = 30.0M;


        private decimal fCostOfBevPerPerson;
        private double fDiscount;
        private decimal fCostOfDecPerPerson;
        private decimal fFlatFeeDecoration;

        public DinnerParty()
        {
        }

        public int NumberOfPeople { get; set; }
        
        public void SetHealthyOption(bool healthy)
        {
            switch (healthy)
            {
                case true:
                    fDiscount = HealthyDiscount;
                    fCostOfBevPerPerson = CostOfSodaPerPerson;
                    break;
                case false:
                    fDiscount = 1;
                    fCostOfBevPerPerson = CostOfAlcPerPerson;
                    break;
            }
        }

        public void SetFancyDecorations(bool fancy)
        {
            switch (fancy)
            {
                case true:
                    fCostOfDecPerPerson = CostOfFancyDecPerPerson;
                    fFlatFeeDecoration = FlatFeeFancyDec;
                    break;
                case false:
                    fCostOfDecPerPerson = CostOfNormalDecPerPerson;
                    fFlatFeeDecoration = FlatFeeNormalDec;
                    break;
            }
        }

        public decimal TotalCost()
        {
            decimal sum = FoodChargePerPerson * NumberOfPeople;
            sum += fCostOfBevPerPerson * NumberOfPeople;
            sum += fCostOfDecPerPerson * NumberOfPeople + fFlatFeeDecoration;
            sum *= (decimal)fDiscount;

            if (NumberOfPeople == 0)
                sum = 0;

            return sum;
        }
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DinnerParty
{
    public class DinnerParty : Party
    {
        private const decimal CostOfAlcPerPerson = 20.0M;
        private const decimal CostOfSodaPerPerson = 5.0M;
        private const double HealthyDiscount = 0.95;

        private decimal fCostOfBevPerPerson;
        private double fDiscount;

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

        private decimal CostOfBeverages()
        {
            return fCostOfBevPerPerson * NumberOfPeople;
        }

        public override decimal TotalCost()
        {
            decimal sum = CostOfFood() +
                            CostOfBeverages() + 
                            CostOfDecorations();
            sum *= (decimal)fDiscount;

            if (NumberOfPeople == 0)
                sum = 0;

            return sum;
        }
    }
}

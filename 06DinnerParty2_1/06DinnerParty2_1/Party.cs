using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DinnerParty
{
    public abstract class Party
    {
        protected const decimal FoodChargePerPerson = 25.0M;
        private const decimal CostOfFancyDecPerPerson = 15.0M;
        private const decimal CostOfNormalDecPerPerson = 7.50M;
        private const decimal FlatFeeFancyDec = 50.0M;
        private const decimal FlatFeeNormalDec = 30.0M;
        
        protected decimal fCostOfDecPerPerson;
        protected decimal fFlatFeeDecoration;
        
        public virtual int NumberOfPeople { get; set; }

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

        protected decimal CostOfFood()
        {
            return FoodChargePerPerson* NumberOfPeople;
        }

        protected decimal CostOfDecorations()
        {
            return fCostOfDecPerPerson * NumberOfPeople + fFlatFeeDecoration;
        }

        public abstract decimal TotalCost();
    }
}

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
        
        protected decimal fCostOfDecPerPerson;
        protected decimal fFlatFeeDecoration;
        
        private const decimal CostOfFancyDecPerPerson = 15.0M;
        private const decimal CostOfNormalDecPerPerson = 7.50M;
        private const decimal FlatFeeFancyDec = 50.0M;
        private const decimal FlatFeeNormalDec = 30.0M;
        
        public int NumberOfPeople { get; set; }
        
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

        public abstract decimal TotalCost();
        public abstract void SetOptions(Form1 form1);
    }
}

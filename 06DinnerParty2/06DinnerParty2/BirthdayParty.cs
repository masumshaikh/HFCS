using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DinnerParty
{
    public class BirthdayParty : Party
    {
        private string fCakeWriting;

        public override decimal TotalCost()
        {
            decimal sum = FoodChargePerPerson * NumberOfPeople;
            sum += (fCostOfDecPerPerson * NumberOfPeople) + fFlatFeeDecoration;
            
            if (NumberOfPeople == 0)
                sum = 0;

            return sum;
        }

        public override void SetOptions(Form1 form1)
        {
            SetFancyDecorations(form1.ChkBoxFancy.Checked);
            SetCakeWriting(form1.TextBoxCakeWriting.Text);
        }

        private void SetCakeWriting(string cakeWriting)
        {
            fCakeWriting = cakeWriting;
        }
    }
}

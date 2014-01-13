using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03Guys
{
    public class Account
    {
        public Account(string name, int cash)
        {
            this.Name = name;
            this.Cash = cash;
        }

        public string Name { get; set; }
        public int Cash { get; set; }

        public static void TransferFromTo(int amount, Account acc1, Account acc2)
        {
            if (acc1.Cash >= amount)
            {
                acc1.Cash -= amount;
                acc2.Cash += amount;
            }
            else
            {
                MessageBox.Show(acc1.Name + " does not have enough cash!");
            }
        }
    }
}

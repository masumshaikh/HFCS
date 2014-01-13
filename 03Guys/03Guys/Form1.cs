using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03Guys
{
    public partial class Form1 : Form
    {
        private Account joe = new Account("Joe", 50);
        private Account bob = new Account("Bob", 100);
        private Account bank = new Account("Bank", 1000);

        public Form1()
        {
            InitializeComponent();
            this.UpdateForm();
        }

        public void UpdateForm()
        {
            FirstPersonLabel.Text  = joe.Name +  " has " + joe.Cash;
            SecondPersonLabel.Text = bob.Name +  " has " + bob.Cash;
            BankLabel.Text         = bank.Name + " has " + bank.Cash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account.TransferFromTo(10, bank, joe);
            this.UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account.TransferFromTo(5, bob, bank);
            this.UpdateForm();
        }
    }
}

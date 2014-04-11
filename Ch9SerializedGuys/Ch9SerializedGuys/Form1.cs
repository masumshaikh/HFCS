using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ch9SerializedGuys
{
    public partial class Form1 : Form
    {
        private Account fJoe = new Account("Joe", 50);
        private Account fBob = new Account("Bob", 100);
        private Account fBank = new Account("Bank", 1000);

        public Form1()
        {
            InitializeComponent();
            this.UpdateForm();
        }

        public void UpdateForm()
        {
            FirstPersonLabel.Text  = this.fJoe.Name +  " has " + this.fJoe.Cash;
            SecondPersonLabel.Text = this.fBob.Name +  " has " + this.fBob.Cash;
            BankLabel.Text         = this.fBank.Name + " has " + this.fBank.Cash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account.TransferFromTo(10, this.fBank, this.fJoe);
            this.UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account.TransferFromTo(5, this.fBob, this.fBank);
            this.UpdateForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Accounts.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(output, this.fJoe);
                binaryFormatter.Serialize(output, this.fBob);
                binaryFormatter.Serialize(output, this.fBank);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Accounts.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                fJoe = (Account)binaryFormatter.Deserialize(input);
                fBob = (Account)binaryFormatter.Deserialize(input);
                fBank = (Account)binaryFormatter.Deserialize(input);
            }

            this.UpdateForm();
        }
    }
}

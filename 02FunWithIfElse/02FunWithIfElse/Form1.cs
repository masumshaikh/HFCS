using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02FunWithIfElse
{
    using System.Diagnostics.CodeAnalysis;

    public partial class Form1 : Form
    {
        private bool fLabelIsOrigColour = true;
        private readonly Color fOrigColor = Color.Red;

        public Form1()
        {
            InitializeComponent();
            fOrigColor = label1.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.BackColor = fLabelIsOrigColour ? Color.Red : fOrigColor;
                fLabelIsOrigColour = !fLabelIsOrigColour;
            }
            else
                MessageBox.Show("checkbox not checked");
        }
    }
}

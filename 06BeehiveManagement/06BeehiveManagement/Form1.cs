using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06BeehiveManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CmboxJobs.SelectedIndex = 0;

            Queen q = new Queen();
        }
    }
}

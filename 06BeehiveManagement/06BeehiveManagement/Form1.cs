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
        private Queen q = new Queen();

        public Form1()
        {
            InitializeComponent();
            CmboxJobs.SelectedIndex = 0;
        }

        private void BtnWorkNextShift_Click(object sender, EventArgs e)
        {
            q.WorkNextShift();
            TxtBoxReport.Text = q.HiveReport;
        }

        private void BtnAssignJob_Click(object sender, EventArgs e)
        {
            bool jobAssigned = q.TryAssignJob(CmboxJobs.Text, (int)NudNumShiftsForJob.Value);
            if (jobAssigned)
                MessageBox.Show(CmboxJobs.Text + " will be done in " + NudNumShiftsForJob.Value + " shifts.", "The queen bee says ...");
            else
                MessageBox.Show("Couldn't find a bee to do the task.", "The queen bee says ...");
        }
    }
}

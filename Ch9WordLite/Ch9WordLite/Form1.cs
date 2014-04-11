using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ch9WordLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = OpenFileDlg.FileName;
                TxtBox.Clear();
                TxtBox.Text = File.ReadAllText(fileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = SaveFileDlg.FileName;
                File.WriteAllText(fileName, TxtBox.Text);
            }
        }
    }
}

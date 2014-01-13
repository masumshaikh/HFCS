using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06Page251DerivedClassesCtors
{
    public class BaseClass
    {
        public BaseClass(string baseClassNeedsThis)
        {
            MessageBox.Show("This is the base class: " + baseClassNeedsThis);
        }
    }
}

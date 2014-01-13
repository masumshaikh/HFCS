using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06Page251DerivedClassesCtors
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass(string baseClassNeedsThis, string derivedClassAlsoNeedsThis)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the derived Class: " + derivedClassAlsoNeedsThis);
        }

    }
}

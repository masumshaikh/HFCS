using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoNS.Visualization;
using ShoNS.Array;
using ShoNS.MathFunc;
using System.Windows.Forms;

namespace ShoTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 1, 2, 3 };
            double[] y = { 1, 2, 6 };
            ShoPlotHelper.Plot(x, y, "rx-");
            ShoPlotHelper.Figure();
            ShoPlotHelper.Plot(x, y, "gx-");

            ////DoubleArray u;
            ////u = DoubleArray.From(x);

            ////DoubleArray v;
            ////v = DoubleArray.From(y);
            ////v.FillRandom(new System.Random());

            ////// Console.WriteLine(string.Format("{0}, {1}", u.Size[0], u.Size[1]));
            ////ShoPlotHelper.Plot(u, v);

            ////DoubleArray A = new DoubleArray(5, 5);
            ////A.FillRandom(new System.Random());
            ////var z = ShoNS.MathFunc.ArrayMath.Sin(new double[] { 1,2,3 });
            ////Console.WriteLine(z);
        }
    }
}

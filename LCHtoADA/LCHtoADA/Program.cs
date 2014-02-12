using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LCHtoADA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testPath = Utility.TestFilesDirectoryName();
            Report18 r18 = new Report18(testPath + "R18.txt");
            Report79 r79 = new Report79(testPath + "R79.txt");
            Report90 r90 = new Report90(testPath + "R90.txt");

            Converter c = new Converter(r18, r79, r90);
            
            c.FillADATable();
            c.ToADA(testPath + "outADA.ada");
        }
    }
}

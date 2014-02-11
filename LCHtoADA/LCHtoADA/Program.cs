using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LCHtoADA
{
    public class Program
    {
        static void Main(string[] args)
        {
            string testPath = LCHtoADA.Program.TestFilesDirectoryName();
            Report18 r18 = new Report18(testPath + "R18.txt");
            Report79 r79 = new Report79(testPath + "R79.txt");
            Report90 r90 = new Report90(testPath + "R90.txt");

            Converter c = new Converter(r18, r79, r90);
            List<DateTime> list = r90.AllDates();
            Console.WriteLine(r90["AUD_BBSW", new DateTime(2013, 11, 11), "1W"]);
        }

        public static string TestFilesDirectoryName()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = System.IO.Directory.GetParent(path);
            DirectoryInfo x = Directory.GetParent(directoryInfo.FullName);
            x = Directory.GetParent(x.FullName);
            string y = string.Format("{0}\\TestFiles\\", x.FullName);

            return y;
        }
    }
}

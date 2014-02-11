using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCHtoADA
{
    class Program
    {
        static void Main(string[] args)
        {
            LCHFile r79 = new Report79("R79short.txt");
            Console.WriteLine(r79.DataTable.Rows[r79.DataTable.Rows.Count - 1]["DiscountFactor"]);
            LCHFile r90 = new Report90("R90.txt");
            Console.WriteLine(r90.DataTable.Rows[3]["6M"]);
            Report18 r18 = new Report18("R18.txt");
            Console.WriteLine(r18.DataTable.Rows[3]["Exchangerate"]);
            double x = r18["AUD"];
            Console.WriteLine(x);
        }
    }
}

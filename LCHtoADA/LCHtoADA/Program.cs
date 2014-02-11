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
            Report79 r79 = new Report79("R79short.txt");
            Report90 r90 = new Report90("R90.txt");
            Report18 r18 = new Report18("R18.txt");

            var c = new Converter(r18, r79, r90);
        }
    }
}

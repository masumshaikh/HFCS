using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch8_Ducks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ducks = new Ducks()
            {
                new Duck(17, Duck.KindOfDuck.Mallard),
                new Duck(18, Duck.KindOfDuck.Muscovy),
                new Duck(14, Duck.KindOfDuck.Decoy),
                new Duck(11, Duck.KindOfDuck.Muscovy),
                new Duck(14, Duck.KindOfDuck.Mallard),
                new Duck(13, Duck.KindOfDuck.Decoy),
            };

            Console.WriteLine(ducks);
            Console.WriteLine("\n");

            Console.WriteLine("Using CompareTo..............................\n");
            ducks.Sort();
            Console.WriteLine(ducks);

            Console.WriteLine("Using DuckComparer SizeThenKind..............................\n");
            DuckComparer comparer = new DuckComparer(DuckComparer.SortCriteria.SizeThenKind); 
            ducks.Sort(comparer);
            Console.WriteLine(ducks);

            Console.WriteLine("Using DuckComparer KindThenSize..............................\n");
            comparer.SortCriterion = DuckComparer.SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            Console.WriteLine(ducks);
            
            Console.ReadKey();
        }
    }
}

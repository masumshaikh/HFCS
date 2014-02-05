using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFrame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataFrame d = new DataFrame(new List<string>() {"ford", "vauxhall"}, new List<string>() {"35932", "35933"});
            Console.WriteLine(d["ford", "35933"] + "\n");

            d = new DataFrame(new List<string>() {"ford", "vauxhall"},
                                new List<string>() {"35932", "35933"},
                                new dynamic[2,2] { {1.1,1.2}, {2.1,2.2} });

            d["ford", "35933"] = "crikey";
            Console.WriteLine(d["ford", "35933"] + "\n");
            
        }
    }
}

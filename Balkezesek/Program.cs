using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<beo> balekezes = new List<beo>();
            foreach (var sor in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                balekezes.Add(new beo(sor));
            }
        }
    }
}

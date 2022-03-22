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
            Console.WriteLine($"3.feladat: {balekezes.Count}");

            Console.WriteLine($"4.feladat:");
            balekezes
                .Where(x => x.utolsopalyalepes.Year == 1999 && x.utolsopalyalepes.Month == 10)
                .ToList()
                .ForEach(x => Console.WriteLine("{0},{1:0.0}",x.nev,x.magassag*2.54));

            Console.WriteLine($"5.feladat:");

            bool boolteszt = false;
            int bekertsz;
            do
            {
            Console.WriteLine("Kérek egy 1990 és 1999 közötti számot!:");
            bekertsz = int.Parse(Console.ReadLine());
                if (bekertsz >= 1990 && bekertsz <= 1999)
                {
                    boolteszt= true;
                    
                }
                else
                {
                    Console.Write("Hiba! ");
                }
            } while (boolteszt==false);

            Console.WriteLine("6.feladat: {0:0.00} font", balekezes.Where(x => x.elsopalyalepes.Year <= bekertsz && x.utolsopalyalepes.Year>=bekertsz).Average(x => x.suly));

        }
    }
}

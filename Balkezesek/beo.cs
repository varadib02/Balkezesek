using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class beo
    {
        public string nev { get; set; }
        public DateTime elsopalyalepes { get; set; }
        public DateTime utolsopalyalepes { get; set; }
        public int suly { get; set; }
        public int magassag { get; set; }

        public beo(string sor)
        {
            string[] db = sor.Split(';');
            nev = db[0];
            elsopalyalepes = DateTime.Parse(db[1]);         
            utolsopalyalepes = DateTime.Parse(db[2]);         
            suly = int.Parse(db[3]);         
            magassag = int.Parse(db[4]);         
        }
    }
}

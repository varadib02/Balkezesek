using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class player
    {
        //field
        public string nev;
        private int tömeg;
        //methodus
        public int gettömeg() 
        {
            return tömeg;
        }

        public void settömeg(int t)
        {
            //tömeg = t;
            if (t<0)
            {
                throw new Exception("hibás tömeg");
            }
            else
            {
                tömeg=t;
            }
        }
        //property
        //public int TÖMEG { get; set; }
        public int TÖMEG
        {
            get
            { 
                return tömeg / 1000; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("hibás tömeg");
                }
                else
                {
                    tömeg = value;
                }
            } 
        }

        public int tomeg { get => tömeg / 1000; }

    }
}

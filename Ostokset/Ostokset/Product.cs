using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostokset
{
    class Product
    {
        string Nimi { get; set; }
        double Hinta { get; set; }

        public Product(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }

        public override string ToString()
        {
            string sisalto = Nimi + " " + Hinta + "e";


            return sisalto;
        }

    }
}

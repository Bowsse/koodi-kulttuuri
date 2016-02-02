using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Rengas
    {
        public string Merkki { get; set; }

        public string Tyyppi { get; set; }

        public string Rengaskoko { get; set; }

        public Rengas(string merkki, string tyyppi, string rengaskoko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Rengaskoko = rengaskoko;
        }

        public override string ToString()
        {
            return "rengas: " + Merkki + ", " + Tyyppi + ", " + Rengaskoko;
        }

    }
    class Kulkuneuvo
    {
        public Kulkuneuvo(string nimi, string malli)
        {
            Nimi = nimi;
            Malli = malli;

            renkaat = new List<Rengas>();

            renkaat.Add(new Rengas("Mitchelin", "X-Ice", "225/45917"));
            renkaat.Add(new Rengas("Mitchelin", "X-Ice", "225/45917"));
            renkaat.Add(new Rengas("Mitchelin", "X-Ice", "225/45917"));
            LisääRengas(new Rengas("Mitchelin", "X-Ice", "225/45917"));

        }

        public string Nimi { get; set; }

        public string Malli { get; set; }

        private List<Rengas> renkaat;

        public void PoistaRenkaat()
        {
            renkaat.Clear();
        }
        public void LisääRengas(Rengas r)
        {
            renkaat.Add(r);
        }

        

        public override string ToString()
        {
            string s = "auto: " + Nimi + ", " + Malli;

            foreach(Rengas r in renkaat)
            {
                s += "\n";
                s += r.ToString();
            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo auto = new Kulkuneuvo("Ferrari", "458");

            Console.WriteLine(auto.ToString());

            auto.PoistaRenkaat();

            auto.LisääRengas(new Rengas("Mitchelin", "X-Ice", "225/45917"));

            Console.WriteLine(auto.ToString());

            
        }


    }
}
    


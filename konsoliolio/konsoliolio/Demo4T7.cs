using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tavara
    {
        public Tavara(string nimi, string tekijä)
        {
            this.nimi = nimi;
            this.tekijä = tekijä;
        }
        public Tavara()
        {

        }

        private string nimi;

        private string tekijä;

        public string Nimi
        {
            get { return nimi; }

            set { nimi = value; }

        }
        public string Tekijä
        {
            get { return tekijä; }

            set { tekijä = value; }

        }

        public override string ToString()
        {
            return nimi + " tekijä: " + tekijä;
        }


    }
    class CDlevy : Tavara
    {
        public double Kesto { get; set; }
        public CDlevy()
        {

        }
        public CDlevy(string nimi, string tekijä, double kesto)
            : base(nimi, tekijä)
        {
            Kesto = kesto;
        }
        public override string ToString()
        {
            return base.ToString() + " kesto: " + Kesto;
        }


    }
    class Kirja : Tavara
    {
        public int Sivuja { get; set; }
        public Kirja()
        {

        }
        public Kirja(string nimi, string tekijä, int sivuja)
            : base(nimi, tekijä)
        {
            Sivuja = sivuja;
        }
        public override string ToString()
        {
            return base.ToString() + " sivuja: " + Sivuja;
        }
    }
    public class Huone
    {
        List<Kirja> Kirjat { get; set; }
        List<CDlevy> Levyt { get; set; }


    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Kirja kirja1 = new Kirja();
            Kirja kirja2 = new Kirja("aapinen", "joku kehari", 600);

            CDlevy cd1 = new CDlevy();
            CDlevy cd2 = new CDlevy("räppikiekko", "sorsapillikeekki", 55.4);

            cd1.Nimi = "piraatti";

            Console.WriteLine(kirja2.ToString());
            Console.WriteLine(cd2.ToString());

            
        }


    }
}
    


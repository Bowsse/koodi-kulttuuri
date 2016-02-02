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



    }
    class CDlevy : Tavara
    {
        public CDlevy()
        {

        }
        public CDlevy(string nimi, string tekijä)
            : base(nimi, tekijä)
        {

        }
    }
    class Kirja : Tavara
    {
        public Kirja()
        {

        }
        public Kirja(string nimi, string tekijä)
            : base(nimi, tekijä)
        {

        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Kirja kirja1 = new Kirja();
            Kirja kirja2 = new Kirja("aapinen", "joku kehari");

            CDlevy cd1 = new CDlevy();
            CDlevy cd2 = new CDlevy("räppikiekko", "sorsapillikeekki");

            cd1.Nimi = "piraatti";

            Console.WriteLine("Huoneesta lyötyy {0} jonka kirjotti {1} ja joku {2} levy jonka tekijä = {3}, ja sitte vielä tommone {4} jonka teki {5}", kirja2.Nimi, kirja2.Tekijä, cd1.Nimi, cd1.Tekijä, cd2.Nimi, cd2.Tekijä);


        }


    }
}
    


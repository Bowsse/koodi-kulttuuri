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

    


    /*Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.

Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).

Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.*/

    class Program
    {
        static void Main(string[] args)
        {
            IMammal1 mammal = new Human();
            mammal.Move(5);
            
        }


    }
}
    


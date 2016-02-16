using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    [Serializable]
    class Ohjelma
    {
        public string Nimi { get; set; }

        public string Kanava { get; set; }

        public double Alku { get; set; }

        public double Loppu { get; set; }

        public string Info { get; set; }

        public Ohjelma(string nimi, string kanava, double alku, double loppu, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            Alku = alku;
            Loppu = loppu;
            Info = info;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Ohjelma> ohjelmat = new List<Ohjelma>();

            ohjelmat.Add(new Ohjelma("Isojalan jäljillä", "FOX", 16.55, 17.25, "Rygge tietää mistä täydellisen aplarin löytää"));
            ohjelmat.Add(new Ohjelma("Iasdasdä", "SUB", 11.55, 12.25, "NO KERRO JO"));


            Stream writems = new FileStream("Ohjelmatlista.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(writems, ohjelmat);

            writems.Close();


            Stream openStream = new FileStream("Ohjelmatlista.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            List<Ohjelma> readOhjelmat = (List<Ohjelma>)formatter.Deserialize(openStream);

            openStream.Close();

            foreach (Ohjelma o in readOhjelmat)
            {
                Console.WriteLine("Ohjelman nimi: {0}, kanava: {1}, alkaa: {2}, loppuu: {3}, info: {4}", o.Nimi, o.Kanava, o.Alku, o.Loppu, o.Info);
            }

        }


    }
}
    


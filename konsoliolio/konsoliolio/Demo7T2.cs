using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int koko = 0;
            bool loppu = false;
            double reaali = 0;

            StreamWriter intti = new System.IO.StreamWriter("T2Integers.txt");
            intti.Close();
            StreamWriter doubbel = new System.IO.StreamWriter("T2Doubles.txt");
            doubbel.Close();

            do
            {
                Console.WriteLine("Give a number : ");
                a = Console.ReadLine();

                try
                {
                    reaali = double.Parse(a);

                    try
                    {
                        koko = int.Parse(a);

                        File.AppendAllText("T2Integers.txt", koko + Environment.NewLine);

                    }
                    catch (System.FormatException)
                    {
                        File.AppendAllText("T2Doubles.txt", reaali + Environment.NewLine);
                    }

                }
                catch (System.FormatException)
                {
                    loppu = true;
                }

                
            } while (!loppu);

        }


    }
}
    


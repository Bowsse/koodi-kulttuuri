using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka, kulutus, hinta;
            kulutus = 0.0702;
            hinta = 1.595;

            Console.WriteLine("Anna matka > ");

            matka = double.Parse(Console.ReadLine());

            Console.WriteLine("Bensaa kuluu {0} litraa, kustannus {1} euroa", kulutus * matka, kulutus * matka * hinta);




        }


        }
    }


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
            int pisteet;

            Console.Write("Anna pistemäärä > ");

            pisteet = int.Parse(Console.ReadLine());

            if (pisteet >= 0 && pisteet <= 1)
            {
                Console.WriteLine("Koulunumero on 0");
            }
            else if (pisteet >= 2 && pisteet <= 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            else if (pisteet >= 4 && pisteet <= 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            else if (pisteet >= 6 && pisteet <= 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            else if (pisteet >= 8 && pisteet <= 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            else if (pisteet >= 10 && pisteet <= 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            else
            {
                Console.WriteLine("Annoit jonkun muun luvun");
            }


        }
    }
}

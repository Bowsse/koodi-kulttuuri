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
            int l1, l2, l3, summa;
            double ka;


            Console.WriteLine("Anna kolme lukua: ");

            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            summa = l1 + l2 + l3;
            ka = (double)summa / 3;

            Console.WriteLine("Summa: {0}", summa);
            Console.WriteLine("Keskiarvo: {0:f2}", ka);

        }


        }
    }


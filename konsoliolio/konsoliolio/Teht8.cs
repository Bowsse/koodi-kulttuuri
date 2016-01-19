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
            int l1, l2, l3, isoin;

            Console.WriteLine("Anna luku: ");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            l3 = int.Parse(Console.ReadLine());

            if (l1 >= l2)
            {
                isoin = l1;
            }
            else
            {
                isoin = l2;
            }
            if (l3 > isoin)
            {
                isoin = l3;
            }
            Console.WriteLine("Suurin luku on {0}", isoin);

        }


        }
    }


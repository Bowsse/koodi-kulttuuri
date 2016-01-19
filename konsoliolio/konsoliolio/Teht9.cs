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
            int luku;
            int summa = 0;
            
            do
            {
                Console.WriteLine("Anna luku > ");
                luku = int.Parse(Console.ReadLine());

                summa = summa + luku;

            } while (luku != 0);

            Console.WriteLine("Lukujen summa on {0}", summa);

        }


        }
    }


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
            int ika;

            Console.WriteLine("Kerro ikä: ");

            ika = int.Parse(Console.ReadLine());

            if(ika < 18)
            {
                Console.WriteLine("alaikäinen");
            }
            else if(ika >= 18 && ika <= 65)
            {
                Console.WriteLine("aikuinen");
            }
            else
            {
                Console.WriteLine("seniori");
            }

        }


        }
    }


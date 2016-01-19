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
            int vuosi;

            Console.WriteLine("Anna vuosi > ");

            vuosi = int.Parse(Console.ReadLine());

            int jj = vuosi % 4;


            if (jj == 0)
            {
                jj = vuosi % 100;
                if (jj != 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi.");
                }
                jj = vuosi % 400;

                if (jj == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi.");
                }
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
            jj = vuosi % 100;
            if (jj == 0)
            {
                jj = vuosi % 400;

                if (jj != 0)
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
            }
        }


        }
    }


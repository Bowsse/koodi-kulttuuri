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
            int sekunnit;

            Console.WriteLine("Anna sekunnit > ");

            sekunnit = int.Parse(Console.ReadLine());

            int tunnit, minuutit;

            tunnit = sekunnit / 3600;
            minuutit = sekunnit / 60;

            sekunnit = sekunnit - (minuutit * 60);

            minuutit = minuutit - (tunnit * 60);

            Console.WriteLine("{0} tunti {1} minuutti {2} sekuntti", tunnit, minuutit, sekunnit);


        }


        }
    }


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
            int[] taulu = { 1, 2,33,44,55,68,77,96,100 };
            int jj;

            for(int i = 0; i <= 8; i++)
            {
                jj = taulu[i] % 2;
                if(jj == 0)
                {
                    Console.WriteLine("HEP");
                }
                
            }



        }


        }
    }


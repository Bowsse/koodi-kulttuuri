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
            string sana = "hirsipuu";
            char[] laini = { '_', '_', '_', '_', '_', '_', '_', '_' };

            char[] s = sana.ToCharArray();

            char kirjain;

            int yritys = 5;

            do
            {
                Console.WriteLine("Arvaa kirjain");
                kirjain = Console.ReadKey().KeyChar;

                for(int i = 0; i < s.Length; i ++)
                {
                    if(kirjain == s[i])
                    {
                        laini[i] = kirjain;
                    }
                }
                Console.WriteLine();

                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write("{0}", laini[i]);
                }
                Console.WriteLine();

              yritys = yritys - 1;
            } while (yritys > 0);


        }


    }
    }


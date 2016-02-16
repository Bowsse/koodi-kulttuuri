using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace randomihenki
{
    class Program
    {
        static private Random rand;

        static string RandomString(int length)
        {
            string ret = "";
            for(int i = 0; i<length; i++)
            {
                ret += (char)rand.Next('A', 'Z');
            }
            return ret;
            
        }
        static void Main(string[] args)
        {
            rand = new Random();

            List<Henkilo> persons = new List<Henkilo>();

            const int personCount = 10000;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for(int i=0; i<personCount; i++)
            {
                Henkilo p = new Henkilo(RandomString(12), RandomString(4), RandomString(8), rand.Next(1, 100), rand.Next(30, 140), rand.Next(100, 220));
                persons.Add(p);
            }
            sw.Stop();
            Console.Write(sw.ElapsedMilliseconds + "ms\n");
            sw.Start();
            for (int i =0; i < 1000; i++)
            {
                string nameToFind = RandomString(4);

                Henkilo p = persons.Find(x => x.FirstName == nameToFind);

                
                if(p != null)
                {
                    Console.WriteLine("Found person with firstname " + nameToFind + " : " + p.FirstName + p.LastName);
                }
               
            }
            sw.Stop();

            Console.Write(sw.ElapsedMilliseconds);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt6T1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Henkilo> henkilot = new List<Henkilo>();

            henkilot.Add(new Henkilo("52355-245", "Pekka", "Pouta", 39, 78, 182));
            henkilot.Add(new Henkilo("12355-253", "Jukka", "Pinta", 49, 68, 172));
            henkilot.Add(new Henkilo("178955-153", "Mikko", "Pauna", 33, 76, 194));
            henkilot.Add(new Henkilo("22357-63", "Matti", "Nauta", 22, 82, 182));
            henkilot.Add(new Henkilo("43256-853", "Maija", "Pöytä", 55, 97, 179));
            henkilot.Add(new Henkilo("62464-7433", "Raija", "Bouta", 32, 54, 169));
            henkilot.Add(new Henkilo("98723-444", "Eeva", "Routa", 79, 52, 156));

            henkilot.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach (Henkilo s in henkilot)
            {
                Console.Write(s.ToString());
            }

            string SSN = "12355-253";


            Henkilo found = henkilot.Find(x => x.SSN == SSN);

            if(found != null)
            {
                Console.Write("Person with SSN " + SSN + " found!");
                henkilot.Remove(found);
            }
            else
            {
                Console.Write("Person not found.");
            }

            for(int i = 0; i< henkilot.Count; i++)
            {
                if (henkilot[i].Age == 79)
                {
                    henkilot.RemoveAt(i);
                    i = -1;
                }
            }

            /*
            foreach(Henkilo s in henkilot)
            {
                if(s.SSN == SSN)
                {
                    Console.Write("Person with SSN " + SSN + " found! " + s.FirstName);
                    break;
                }
            }
            */

        }
    }
}

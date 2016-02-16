using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Radio
    {
        public Radio()
        {
            this.kytkin = false;
            this.voimakkuus = 0;
            this.taajuus = 2000.0;

        }

        private bool kytkin;

        private int voimakkuus;

        private double taajuus;

        public bool Kytkin
        {
            get { return kytkin; }

            set { kytkin = value; }

        }

        public int Voimakkuus
        {
            get { return voimakkuus; }

            set
            {
                if (value >= 1 && value <= 9)
                {
                    voimakkuus = value;
                }
                else
                {
                    Console.WriteLine("Väärä arvo.");
                }
                     
            }

        }

        public double Taajuus
        {
            get { return taajuus; }

            set
            {
                if (value >= 2000 && value <= 26000)
                {
                    taajuus = value;
                }
                else
                {
                    Console.WriteLine("Väärä arvo.");
                }

            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int valinta;

            Radio radio1 = new Radio();

                radio1.Kytkin = true;
                radio1.Voimakkuus = 9;
                radio1.Taajuus = 26000.0;

                Console.WriteLine("Päällä: {0}, voimakkuus; {1}, taajuus: {2}", radio1.Kytkin, radio1.Voimakkuus, radio1.Taajuus);

            do
            {
                Console.WriteLine("0: pois päältä");
                Console.WriteLine("1: aseta voimakkuus (1-9)");
                Console.WriteLine("2: aseta taajuus (2000.0-26000.0");

                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {

                    case 0:
                        radio1.Kytkin = false;
                        break;
                    case 1:
                        Console.WriteLine("Anna voimakkuus (1-9): ");
                        radio1.Voimakkuus = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Anna taajuus (2000.0-26000.0): ");
                        radio1.Taajuus = int.Parse(Console.ReadLine());
                        break;
                }


                Console.WriteLine("Päällä: {0}, voimakkuus; {1}, taajuus: {2}", radio1.Kytkin, radio1.Voimakkuus, radio1.Taajuus);

            } while (radio1.Kytkin == true);





        }


    }
}
    


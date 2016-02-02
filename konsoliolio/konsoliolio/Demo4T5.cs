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

            set { voimakkuus = value; }

        }

        public double Taajuus
        {
            get { return taajuus; }

            set { taajuus = value; }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Radio radio1 = new Radio();

                radio1.Kytkin = true;
                radio1.Voimakkuus = 9;
                radio1.Taajuus = 26000.0;

                Console.WriteLine("Päällä: {0}, voimakkuus; {1}, taajuus: {2}", radio1.Kytkin, radio1.Voimakkuus, radio1.Taajuus);





        }


    }
}
    


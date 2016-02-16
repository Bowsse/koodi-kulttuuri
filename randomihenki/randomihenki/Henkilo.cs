using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomihenki
{
    class Henkilo
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Henkilo(string SSN, string firstName, string lastName, int age, int weight, int height)
        {
            this.SSN = SSN;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " \nLastName: " + LastName + " \nSSN: " + SSN + " \nAge: " + Age + " \nWeight: " + Weight + " \nHeight: " + Height + " \n\n";
        }

    }
}

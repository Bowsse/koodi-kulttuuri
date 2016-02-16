using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoT3
{
    abstract class Human : IMammal
    {
        public int Weight { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }

        /*
        override public void Move(int amount)
        {
            Console.WriteLine("Human is moving {0} steps", amount);
        }
        */

        public void GetOlder()
        {
            Age++;
            Console.WriteLine("Human is {0} years old.", Age);
        }
    }
}

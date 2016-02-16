using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoT3
{
    abstract class IMammal
    {

        public int Age { get; set; }
        abstract public void Move(int amount);
        /*
    {
        Console.WriteLine("Mammal is moving {0} steps", amount);
    }
    */
    }
}

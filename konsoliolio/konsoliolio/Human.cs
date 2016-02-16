using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsoliolio
{
    class Human : IMammal1
    {

        override public void Move(int amount)
        {
            Console.WriteLine("Human is moving {0} steps", amount);
        }

    }
}

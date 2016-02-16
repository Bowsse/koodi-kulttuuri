using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoT3
{
    class Babby : Human
    {

        public string Diaper { get; set; }
        override public void Move(int amount)
        {
            Console.WriteLine("Babby is crawling.");
        }

    }
}

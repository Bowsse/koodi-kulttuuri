using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Noppa nobo = new Noppa();

            Console.WriteLine("Montako heittoa?");
            int heittoja = int.Parse(Console.ReadLine());

            nobo.Heitto(heittoja);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> karry = new List<Product>();

            karry.Add(new Product("Appelsiini", 0.30));
            karry.Add(new Product("Maito", 0.90));
            karry.Add(new Product("Naudan J-liha", 3.59));
            karry.Add(new Product("Kahvi", 2.99));

            foreach(Product p in karry)
            {
                Console.WriteLine(p.ToString());
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Babby vauva = new Babby();
            vauva.Move(10);

            Adult iso = new Adult();

            iso.Move(5);

            vauva.Name = "asdasd";
            Console.WriteLine(vauva.Name);

            vauva.Diaper = "paskaset vaipat";

            vauva.Weight = 100;
            
                        
        }
    }
}

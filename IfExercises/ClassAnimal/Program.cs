using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();

            if (a == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (a == "crocodile" || a == "tortoise" || a == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

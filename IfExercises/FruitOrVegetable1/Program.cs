using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().ToLower();

            if (a == "banana" ||a == "apple" ||a== "cherry" ||a== "lemon" ||a== "grapes"||a == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (a == "tomato" ||a =="cucumber" ||a == "pepper" ||a == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

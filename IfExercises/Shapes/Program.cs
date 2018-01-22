using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            if (shape == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var lice = a * a;
                Console.WriteLine(lice);
            }
            else if (shape == "rectangle")
            {
                var g = double.Parse(Console.ReadLine());
                var j = double.Parse(Console.ReadLine());
                var qjmikura = g * j;
                Console.WriteLine(qjmikura);
            }
            else if (shape == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                var c = double.Parse(Console.ReadLine());
                var lice = (h * c) / 2;
                Console.WriteLine(lice);
            }
            else if (shape == "circle")
            {
                var b = double.Parse(Console.ReadLine());
                var lice = Math.PI * b * b;
                Console.WriteLine(lice);
            }


        }
    }
}

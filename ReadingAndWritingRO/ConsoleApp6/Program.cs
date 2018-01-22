using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var d = 2 * r;
            var area = Math.PI * r * r;
            var perimeter = Math.PI * d;
            Console.WriteLine("Area = {0}, Perimeter = {1}", Math.Round(area, 2), Math.Round(perimeter, 2));
        }
    }
}

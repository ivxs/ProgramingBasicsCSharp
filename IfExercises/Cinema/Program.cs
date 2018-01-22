using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Console.ReadLine();
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = a * b;
            
            if (d == "Premiere")
            {
                var result = c * 12.00;
                Console.WriteLine($"{result:f2}");
            }
            else if (d == "Normal")
            {
                var result = c * 7.50;
                Console.WriteLine($"{result:f2}");
            }
            else if (d == "Discount")
            {
                var result = c * 5.00;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}

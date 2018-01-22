using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());       
            var LenghtNet = 2 * (lenght + b);
            var PriceNet = LenghtNet * price;
            var AreaNet = LenghtNet * height;
            var WeightTotal = AreaNet * weight;
            Console.WriteLine(LenghtNet);
            Console.WriteLine($"{PriceNet:f2}");
            Console.WriteLine($"{WeightTotal:f3}");
        }
    }
}

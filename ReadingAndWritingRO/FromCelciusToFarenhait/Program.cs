using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var farenhait = celsius * 1.8 + 32;
            Console.WriteLine(farenhait);
        }
    }
}

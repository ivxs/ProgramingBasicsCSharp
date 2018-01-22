using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var centimeter = inches * 2.54;
            Console.WriteLine(centimeter);
        }
    }
}

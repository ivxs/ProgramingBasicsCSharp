using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var input = (Console.ReadLine());
            var output = (Console.ReadLine());
            var mid = 0;

            if (input == "mm")
            {
                mid = (int)number * 1000;

            }
            else if (input == "m")
            {
                mid = (int)number * 1000;

            }
            else if (input == "cm")
            {
                mid = (int)number * 100;

            }
            else if (input == "mi")
            {
                mid = (int)number * 1000;

            }
            else if (input == "in")
            {
                mid = (int)number / 1000;

            }
           else if (input == "km")
            {
                mid = (int)number * 1000;

            }
            else if (input == "ft")
            {
                mid = (int)number * 1000;

            }
            else if (input == "yd")
            {
                mid = number * 1.0936113;

            }
        }
    }
}

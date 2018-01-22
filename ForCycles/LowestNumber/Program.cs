using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var LowestNumber = -100000000;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number < LowestNumber)
                {
                   LowestNumber = number;
                }

            }
            Console.WriteLine(LowestNumber);
        }
    }
}

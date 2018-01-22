using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var left = 0;
            var right = 0;
            for (int i = 0; i < n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }
            if (left == right)
            {
                Console.WriteLine("Yes, sum = " + left);
            }
            else
            {
                var diff = Math.Abs(right - left);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}

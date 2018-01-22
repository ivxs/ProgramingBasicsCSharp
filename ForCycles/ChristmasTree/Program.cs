using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                var stars = i;
                var space = n - stars;
                Console.WriteLine($"{new string(' ', space)}{new string('*', stars)}{" | "}{new string('*', stars)}{new string(' ', space)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //first row
            Console.WriteLine($"{new string('*',n *2)}{new string(' ', n)}{new string('*', n * 2)}");
            //mid row
            var midRow = n - 2;
            var specRow = (n - 3) / 2;
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write($"*{new string('/', n * 2 - 2)}*");
                if (row == specRow)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.WriteLine($"*{new string('/', n * 2 - 2)}*");
            }
            //last row
            Console.WriteLine($"{new string('*', n * 2)}{new string(' ', n)}{new string('*', n * 2)}");
        }
    }
}

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
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string(' ', n - 1)}{new string(' ',1)}{new string('~', 1)}{new string(' ', 1)}{new string('~', 1)}{new string(' ', 1)}{new string('~', 1)}");

            }
            Console.WriteLine($"{new string('=', 3 * n + 5)}{new string(' ', 1)}");
            for (int i = 0; i < n-3; i++)
            {
                Console.WriteLine($"{new string('|',1)}{new string('~',(2 * n) + 4 )}{new string('|', 1)}{new string(' ',n - 1)}{new string('|', 1)}");
            }
            Console.WriteLine($"{new string('=', 3 * n + 5)}{new string(' ', 1)}");
            for (int i = n + 2; i > n; i--)
            {
                Console.WriteLine($"{new string('1', i)}{new string('*', 1)}{new string('@',i)}{new string('@', i)}{new string('/',1)}");
            }
        }
    }
}

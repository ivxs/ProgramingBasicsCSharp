using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class p05NewCoin
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = n * 2;

            Console.WriteLine($"{new string(' ', space)}{new string('\\', n)}{new string('/', n)}");

            for (int i = 1; i <= n - 1; i++)
            {
                var space2 = n * 2 - 2 * i;
                var edge = n - i;
                var fill = 6;
                Console.WriteLine($"{new string(' ', space2)}{new string('\\', edge)}{new string('-', fill * i)}{new string('/', edge)}");
            }
            for (int i = 0; i < n / 3; i++)
            {
                var fill = n - 1;
                var hashtag = n * 4;

                Console.WriteLine($"|{new string('-', fill)}{new string('#', hashtag)}{new string('-', fill)}|");
            }
            Console.WriteLine($"|{new string(' ', n - 1)}{new string('/', n * 2 - 3)} ESTD {new string('\\', n * 2 - 3)}{new string(' ', n - 1)}|");

            for (int i = 0; i < n / 3; i++)
            {
                var fill = n - 1;
                var hashtag = n * 4;

                Console.WriteLine($"|{new string('-', fill)}{new string('#', hashtag)}{new string('-', fill)}|");
            }
            for (int i = n - 1; i >= 1; i--)
            {
                var space2 = n * 2 - 2 * i;
                var edge = n - i;
                var fill = 6;
                Console.WriteLine($"{new string(' ', space2)}{new string('\\', edge)}{new string('-', fill * i)}{new string('/', edge)}");
            }
            Console.WriteLine($"{new string(' ', space)}{new string('/', n)}{new string('\\', n)}");
        }
    }
}
        
    


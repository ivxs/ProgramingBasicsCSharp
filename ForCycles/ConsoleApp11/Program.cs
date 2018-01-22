using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var stars = i;
                var space = n - i;
                Console.WriteLine(new string(' ',space));
                for (int e = 0; e < stars; e++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
           
        }
    }
}

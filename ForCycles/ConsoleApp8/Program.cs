using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                for (int e = 0; e < n; e++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

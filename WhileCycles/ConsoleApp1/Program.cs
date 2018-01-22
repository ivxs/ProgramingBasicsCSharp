using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cur = 1;
            while (cur <= n)
            {
                Console.WriteLine(cur);
                cur = cur * 2 + 1;
            }
        }
    }
}

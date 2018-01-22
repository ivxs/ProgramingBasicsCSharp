using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                var n2 = double.Parse(Console.ReadLine());

            }
            if (n2 <= 22.5 && n2 >= 0)
            {
                Console.WriteLine("Poor Mark");
            }
        }
    }
}

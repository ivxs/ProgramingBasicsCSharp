using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var b = "";
            for (int i = 0; i < n - 2; i++)
            {
                b += "- ";
            }
            //First row
            Console.WriteLine($"+ {b}+");
            //Middle
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine($"| {b}|");
            }

            //Last row
            Console.WriteLine($"+ {b}+");
        }
    }
}

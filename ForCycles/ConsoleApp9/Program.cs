using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                for (int e = 0; e <= i; e++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}

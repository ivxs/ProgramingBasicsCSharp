using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = (Console.ReadLine());
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! You are {age} years old and you are from {town}.");

        }
    }
}

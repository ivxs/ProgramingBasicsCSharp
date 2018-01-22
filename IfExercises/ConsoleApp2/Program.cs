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
            var p = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var q = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (p == "water")
                {
                    Console.WriteLine(0.80 * q);
                }
               else if (p == "beer")
                {
                    Console.WriteLine(1.20 * q);
                }
               else if (p == "sweets")
                {
                    Console.WriteLine(1.45 * q);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(1.60 * q);
                }
                else if (p == "coffee")
                {
                    Console.WriteLine(0.50 * q);
                }
            }
            else if (town == "plovdiv")
            {
                if (p == "water")
                {
                    Console.WriteLine(0.70 * q);
                }
                else if (p == "beer")
                {
                    Console.WriteLine(1.15 * q);
                }
                else if (p == "sweets")
                {
                    Console.WriteLine(1.30 * q);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(1.50 * q);
                }
                else if (p == "coffee")
                {
                    Console.WriteLine(0.40 * q);
                }
            }
            else if (town == "varna")
            {
                if (p == "water")
                {
                    Console.WriteLine(0.70 * q);
                }
                else if (p == "beer")
                {
                    Console.WriteLine(1.10 * q);
                }
                else if (p == "sweets")
                {
                    Console.WriteLine(1.35 * q);
                }
                else if (p == "peanuts")
                {
                    Console.WriteLine(1.55 * q);
                }
                else if (p == "coffee")
                {
                    Console.WriteLine(0.45 * q);
                }
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }

    }
}

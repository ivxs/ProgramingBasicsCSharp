using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();
            //BGN, USD, EUR, GBP
            //softuni.bg/forum/8989/domashno-14-zadacha-konzolen-mejduvaluten-konvertor-programming-101-simple-calculations//
            if (first == "bgn")
            {
                if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num / 1.95583, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
            }

            if (first == "usd")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.79549) / 1.95583, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.79549) / 2.53405, 2));
                }
            }

            if (first == "eur")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.95583, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.95583) / 1.79549, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round((num * 1.95583) / 2.53405, 2));
                }
            }

            if (first == "gbp")
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round((num * 2.53405) / 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round((num * 2.53405) / 1.95583, 2));
                }
        }
    }
}

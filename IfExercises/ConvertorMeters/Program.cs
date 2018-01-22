using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorMeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = double.Parse(Console.ReadLine());
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            if (a == "m")
            {
                if (b == "mm")
                {
                    var e = d * 1000;
                    Console.WriteLine(e);
                }
                else if (b == "cm")
                {
                    var e = d * 100;
                    Console.WriteLine(e);
                }
                else if (b == "mi")
                {
                    var e = Math.Round(d / 1609.344, 2);
                    Console.WriteLine(e);
                }
                else if (b == "in")
                {
                    var e = d * 39.37;
                    Console.WriteLine(e);
                }
                else if (b == "km")
                {
                    var e = d / 1000;
                    Console.WriteLine(e);
                }
                else if (b == "ft")
                {
                    var e = d * 3.28;
                    Console.WriteLine(e);
                }
                else if (b == "yd")
                {
                    var e = d * 1.0936;
                    Console.WriteLine(e);
                }
            if (a == "mm")
                {
                    if (b == "m")
                    {
                        var e = d / 1000;
                        Console.WriteLine(d);
                    }
                    else if (b == "cm")
                    {
                        var e = d / 100;
                        Console.WriteLine(e);
                    }
                    else if (b == "mi")
                    {
                        var e = d / 1609.344;
                        Console.WriteLine(e);
                    }
                    else if (b == "in")
                    {
                        var e = d * 39.37;
                        Console.WriteLine(e);
                    }
                    else if (b == "km")
                    {
                        var e = d * 10000;
                        Console.WriteLine(e);
                    }
                    else if (b == "ft")
                    {
                        var e = d * 3.28;
                        Console.WriteLine(e);
                    }
                    else if (b == "yd")
                    {
                        var e = d * 1.0936;
                        Console.WriteLine(e);
                    }
                    if (a == "cm")


                }
            }
        }
    }
}

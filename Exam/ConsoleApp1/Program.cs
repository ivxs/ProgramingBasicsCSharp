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
            var volume = double.Parse(Console.ReadLine());
            var pipe1 = double.Parse(Console.ReadLine());
            var pipe2 = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var total1 = pipe1 * hours;
            var total2 = pipe2 * hours;
            var total1and2 = total1 + total2;

            if (total1and2 > volume)
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {total1and2 - volume:f1} liters.");
            }
            else
            {
                var per = Math.Floor(total1and2 / volume * 100);
                var per1 = Math.Floor(total1 / total1and2 * 100);
                var per2 = Math.Floor(total2 / total1and2 * 100);
                Console.WriteLine($"The pool is {per}% full. Pipe 1: {per1}%. Pipe 2: {per2}%.");
                    

            }
        }
    }
}

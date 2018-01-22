using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var even = 0;
            var odd = 0;
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                
                if (num % 2 == 0)
                {
                    even += num;
                }
                else
                {
                    odd += num;
                }

            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
            }
            else if (even != odd)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(odd - even)}");
            }
        }
    }
}

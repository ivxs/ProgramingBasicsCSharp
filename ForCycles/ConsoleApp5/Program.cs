using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var greatestNumber = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }
                
            }
            Console.WriteLine(greatestNumber);

        }
    }
}

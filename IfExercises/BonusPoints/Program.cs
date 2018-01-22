using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (num > 1000)

            {
                bonus = num * 0.10;           
            }

           else if (num <= 100)

            {
                bonus = 5;
            }

           else if (num > 100)

            {
                bonus = num * 0.2;
            }

            if (num % 10 == 5)

            {
                bonus += 2;
            }

            else if (num % 2 == 0)

            {
                bonus ++ ;
            }

            Console.WriteLine("{0}", bonus);
            Console.WriteLine("{0}", bonus + num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = double.Parse(Console.ReadLine());
            if (a >= 5.50)
            {
                Console.WriteLine("Excellent {0}{1}", a, a);
            }
            else
            {
                Console.WriteLine();
            }
            //.Lenght - Гледа дължината на думата


        }
    }
}

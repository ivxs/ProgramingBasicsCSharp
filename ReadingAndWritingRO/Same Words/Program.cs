using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            a = a.ToLower();
            b = b.ToLower();
            if (a == b)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}

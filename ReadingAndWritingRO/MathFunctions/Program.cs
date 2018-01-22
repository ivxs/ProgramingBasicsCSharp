using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            //
            Console.WriteLine(Math.Round(a, 2));
            //Вдига на степен Math.Pow( x, y); x - Това което вдигаме на степен y - степента
            //Закръгля до по ниското число Math.Floor();
            //Закръгля до по-голямото число  Math.Ceiling();
            //Закръгля до стандартния начин Math.Round();

        }
    }
}

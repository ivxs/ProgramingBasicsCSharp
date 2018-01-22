using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гаднооо
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var xp = double.Parse(Console.ReadLine());
            var yp = double.Parse(Console.ReadLine());
            var left = Math.Min(x1,x2);
            var right = Math.Max(x1, x2);
            var top = Math.Min(y1,y2);
            var bot = Math.Max(y1, y2);
            var insideHorizontal = (left <= xp) && (xp <= right);
            var insideVertical = (top <= yp) && (yp <= bot);
            if ((insideHorizontal) && (insideVertical))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }




            
        }
    }
}

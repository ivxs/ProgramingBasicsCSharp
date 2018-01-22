using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class p02Altcoins
    {
        static void Main(string[] args)
        {
            var BitcoinX = double.Parse(Console.ReadLine());
            var StartPrice = double.Parse(Console.ReadLine());
            var PriceAtm = double.Parse(Console.ReadLine());
            var Etereum = double.Parse(Console.ReadLine());
            var Neo = double.Parse(Console.ReadLine());

            var Pechalba = BitcoinX * PriceAtm - BitcoinX * StartPrice;
            var PriceEtereum = PriceAtm / 100*7.5;
            var PriceNeo = PriceEtereum / 100*40;
            var TotalPrice = (PriceEtereum * Etereum) + (Neo * PriceNeo);
           
            if (Pechalba > TotalPrice)
            {
                var Pechalba1 = Pechalba - TotalPrice;
                Console.WriteLine($"Stefcho bought {Etereum:f4} Ethereum at a price of {PriceEtereum:f4}");
                Console.WriteLine($"Stefcho bought {Neo:f4} Neo at a price of {PriceNeo:f4}");
                Console.WriteLine($"Stefcho has {Pechalba1:f2} profits left to spend.");
            }
            else
            {
                var MoneyNeeded = Pechalba - TotalPrice;
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {MoneyNeeded:f2} more in profits.");
            }

        }
    }
}

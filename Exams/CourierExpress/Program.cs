using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var kilometers = int.Parse(Console.ReadLine());

            if(type == "express")
            {
                
                if (weight < 1)
                {
                    var price = 0.03;
                    var dds2 = 0.03 % 80;
                    var dds = weight * dds2;
                    var priceDeliver = (kilometers * price) + (kilometers * dds);
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight <= 10 && weight >= 1)
                {
                    var price = 0.05;
                    var dds2 = 0.05 % 40;
                    var dds = weight * dds2;
                    var priceDeliver = (kilometers * price) + (kilometers * dds);
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 11 && weight <= 40)
                {
                    var price = 0.10;
                    var dds2 = 0.10 % 5;
                    var dds = weight * dds2;
                    var priceDeliver = (kilometers * price) + (kilometers * dds);
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 41 && weight <= 90)
                {
                    var price = 0.15;
                    var dds2 = Math.Round(0.15 % 2, 4);
                    var dds = weight * dds2;
                    var priceDeliver = (kilometers * price) + (kilometers * dds);
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 91 && weight <= 150)
                {
                    var price = 0.20;
                    var dds2 = 0.20 % 1;
                    var dds = weight * dds2;
                    var priceDeliver = (kilometers * price) + (kilometers * dds);
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }

            }
            else if(type == "standard")
            {
                if (weight < 1)
                {
                    var price = 0.03;
                    var priceDeliver = kilometers * price;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight <= 10 && weight >= 1)
                {
                    var price = 0.05;
                    var priceDeliver = kilometers * price;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 11 && weight <= 40)
                {
                    var price = 0.10;
                    var priceDeliver = kilometers * price;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 41 && weight <= 90)
                {
                    var price = 0.15;
                    var priceDeliver = kilometers * price;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }
                else if (weight >= 91 && weight <= 150)
                {
                    var price = 0.20;
                    var priceDeliver = kilometers * price;
                    Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {priceDeliver:f2} lv.");
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();
            var kil = double.Parse(Console.ReadLine());
            var taxistart = 0.7;
            var taxiDay = 0.79;
            var taxiNight = 0.9;
            var bus = 0.09;
            var train = 0.06;
            var currenttotalprice = 0.0;
            if (kil >= 100)
            {
                currenttotalprice = kil * train;
            }
            else if (kil >= 20)
            {
                currenttotalprice = bus * kil;   
            }
            else
            {
                if (time == "day")
                {
                    currenttotalprice = taxistart + taxiDay;

                }
                else
                {
                    currenttotalprice = taxiNight + taxistart;
                }
            }
            Console.WriteLine(currenttotalprice);
        }
    }
}

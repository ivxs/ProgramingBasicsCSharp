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
            var n = int.Parse(Console.ReadLine());
            var doge = 0;
            double dogeMoney = 0;
            var iota = 0;
            double iotaMoney = 0;
            var neo = 0;
            double neoMoney = 0;
            var estd = 0;
            double estdMoney = 0;
            for (int i = 0; i < n; i++)
            {
                var valuta = Console.ReadLine();
                var Euro = double.Parse(Console.ReadLine());
                if (valuta == "DOGE")
                {
                    doge ++ ;
                    var dogeMoney1 = Euro * 0.07;
                    dogeMoney += dogeMoney1;

                }
                else if (valuta == "IOTA")
                {
                    iota ++;
                    var iotaMoney1 = Euro * 1.44;
                    iotaMoney += iotaMoney1;
                }
                else if (valuta == "NEO")
                {
                    neo ++;
                    var neoMoney1 = Euro * 28.50;
                    neoMoney += neoMoney1;
                }
                else if (valuta == "ESTD")
                {
                    estd ++;
                    var estdMoney1 = Euro * 25;
                    estdMoney += estdMoney1;
                }
                
            }
            var totalMoneySum = dogeMoney + iotaMoney + neoMoney + estdMoney;
            Console.WriteLine($"Total votes = {n}, Money in market = {totalMoneySum:f2} EUR”");
            Console.WriteLine($"DOGE's contribution: {dogeMoney/ totalMoneySum *100:f2}%; People who use DOGE: {doge}");
            Console.WriteLine($"IOTA's contribution: {iotaMoney/ totalMoneySum * 100:f2}%; People who use IOTA: {iota}");
            Console.WriteLine($"NEO's contribution: {neoMoney/ totalMoneySum*100:f2}%; People who use NEO: {neo}");
            Console.WriteLine($"ESTD's contribution: {estdMoney/ totalMoneySum*100:f2}%; People who use ESTD: {estd}");
        }
    }
}

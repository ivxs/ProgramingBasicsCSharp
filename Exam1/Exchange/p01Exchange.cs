using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class p01Exchange
    {
        static void Main(string[] args)
        {
            var dollars = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var satoshi = int.Parse(Console.ReadLine());
            var BitcoinThatCanBeBought = dollars / price;
            var TaxForBuyingBitCoin = BitcoinThatCanBeBought * (satoshi * 1024) / 100000000;
            var TotalBitcoinBought = BitcoinThatCanBeBought - TaxForBuyingBitCoin;
            var Sallary = TotalBitcoinBought * 10 / 100;
            var TaxInDollars = TaxForBuyingBitCoin * price;
            var RemainingBitcoin = TotalBitcoinBought - Sallary;
            Console.WriteLine($"Total bitcoin after expenses: {RemainingBitcoin:f5} BTC");
            Console.WriteLine($"Tax payed: {TaxInDollars:f2} USD");
            Console.WriteLine($"Programmer`s payment: {Sallary:f5} BTC");
           
        }
    }
}

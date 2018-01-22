using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class p03
    {
        static void Main(string[] args)
        {
            var valuta = Console.ReadLine();
            var Euro = Double.Parse(Console.ReadLine());
            var xrp = Euro / 0.22;
            var btc = Euro / 6400;
            var eth = Euro / 250;
            if (xrp < 80 || btc < 0.001 || eth < 0.0099)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                if (Euro > 1000)
                {
                    var Euro1 = Euro / 100 * 10;
                    var Euro2 = Euro1 + Euro;
                    if (valuta == "XRP")
                    {

                        if (xrp > 2500)
                        {
                            var xrp1 = xrp / 100 * 10;
                            var xrp2 = xrp1 + xrp;
                            Console.WriteLine($"Successfully purchased {xrp2:f3} XRP");
                        }
                        else if (xrp < 2500 && xrp > 1000)
                        {
                            var xrp1 = xrp / 100 * 5;
                            var xrp2 = xrp1 + xrp;
                            Console.WriteLine($"Successfully purchased {xrp2:f3} XRP");
                        }
                        else 
                        {
                            Console.WriteLine($"Successfully purchased {xrp:f3} XRP");
                        }
                    }
                    else if (valuta == "BTC")
                    {

                        if (btc > 10)
                        {
                            var btc1 = btc / 100 * 2;
                            var btc2 = btc1 + btc;
                            Console.WriteLine($"Successfully purchased {btc2:f3} BTC");
                        }
                        else
                        {
                            Console.WriteLine($"Successfully purchased {btc} BTC");
                        }
                    }
                    else if (valuta == "ETH")
                    {
                        Console.WriteLine($"Successfully purchased {eth} ETH");
                    }
                    else
                    {
                        Console.WriteLine($"EUR to {valuta} is not supported.");
                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var domati = double.Parse(Console.ReadLine());
            var kasetki = double.Parse(Console.ReadLine());
            var burkani = double.Parse(Console.ReadLine());
            var lutenica = domati / 5;
            var burkanilutenica = lutenica / 0.535;
            var KasetkiM = burkanilutenica / burkani;
            if (KasetkiM > kasetki)
            {
                Console.WriteLine($"Total lutenica: {Math.Floor(lutenica)} kilograms.");
                Console.WriteLine($"{Math.Floor(KasetkiM - kasetki)} boxes left.");
                Console.WriteLine($"{Math.Floor(burkanilutenica - (kasetki * burkani))} jars left.");
            }
            else
            {
                Console.WriteLine($"Total lutenica: {Math.Floor(lutenica)} kilograms.");
                Console.WriteLine($"{Math.Floor(kasetki - KasetkiM)} more boxes needed.");
                Console.WriteLine($"{Math.Floor((kasetki * burkani) - burkanilutenica)} more jars needed.");
            }
        }
    }
}

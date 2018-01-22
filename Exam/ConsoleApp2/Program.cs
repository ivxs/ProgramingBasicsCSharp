using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = 365;
            var numberofholidays = int.Parse(Console.ReadLine());
            var workdays = days - numberofholidays;

            var numberminsplayedholidays = numberofholidays * 127;
            var numberminsplayedworkdays = workdays * 63;

            var totalminsplayed = numberminsplayedholidays + numberminsplayedworkdays;
            var normtoplay = 30000;

            if(totalminsplayed > normtoplay)
            {
                Console.WriteLine("Tom will run away");
                var moreMinstoplay = totalminsplayed - normtoplay;
                var hoursPlayed = moreMinstoplay / 60;
                var minsPlayed = moreMinstoplay % 60;
                Console.WriteLine($"{hoursPlayed} hours and {minsPlayed} minutes more for play");

            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                var moreMinstoplay = normtoplay - totalminsplayed;
                var hoursPlayed = moreMinstoplay / 60;
                var minsPlayed = moreMinstoplay % 60;
                Console.WriteLine($"{hoursPlayed} hours and {minsPlayed} minutes less for play");
            }

        }
    }
}

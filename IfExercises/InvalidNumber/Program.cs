﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            if (a <= 200 && a >= 100 || a == 0)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

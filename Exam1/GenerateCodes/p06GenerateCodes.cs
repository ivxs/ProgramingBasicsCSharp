using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class p06GenerateCodes
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            int br = 0;
            int i = 0, a = 0, b = 0, e = 0;
            char c = 'a', d = 'b';
            for (i = 0; i <= 7 || i+a+b+c+d+e <= n ; i++)
            {
                for ( a = 0; a <= 7 || i + a + b + c + d + e < n; a++)
                {
                    for (b = 0; b < 8 || i + a + b + c + d + e < n; b++)
                    {
                        
                        for (c = 'a'; c < 'z' || i + a + b + c + d + e < n; c++)
                        {
                            char simboli = c;
                            for ( d = 'a'; d < 'z' || i + a + b + c + d + e < n; d++)
                            {
                                char simbol2 = d;
                                for (e = 0; n <= 7 ||br <=2|| i + a + b + c + d + e <= n; e++)
                                {
                                        if (i+a+b+c+d+e==n)
                                        {


                                            Console.Write(i);
                                            Console.Write(a);
                                            Console.Write(b);
                                            Console.Write(simboli);
                                            Console.Write(simbol2);
                                            Console.Write(e);
                                            Console.Write("  ");
                                            br++;
                                        }       
                                    if (i + a + b + c + d + e > n)
                                    {
                                        break;
                                    }
                                    if (i+a+b+c+d+e>n)
                                    {
                                        break;
                                    }
                                }
                                e = 0;
                            }
                            d = 'a';
                        }
                        c = 'a';

                    }
                    b = 0;
                }
                a = 0;
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamuoliukai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int c = 2;
            int d = 2;
            int e = 2;
            int f = 2;
            int g = 2;

            int h = 1;

            if ((a + b + c) == (d + e + f))
            {
                if (g > h)
                {
                    Console.WriteLine("h kamuoliukas lengvesnis");
                }
                else
                {
                    Console.WriteLine("g kamuoliukas lengvesnis");
                }
            }
            else if((a + b + c) < (d + e + f))
            {
                if(a == b)
                {
                    Console.WriteLine("c kamuoliukas lengvesni");
                }
                else
                {
                    if(a < b)
                    {
                        Console.WriteLine("a kamoliukas lengvesnis");
                    }
                    else
                    {
                        Console.WriteLine("b kamuoliukas lengvesnis");
                    }
                }
            }
            else 
            {
                if(d == e)
                {
                    Console.WriteLine("f kamuoliukas lengvesnis");
                }
                else
                {
                    if(d < e)
                    {
                        Console.WriteLine("d kamuoliukas lengvesnis");
                    }
                    else
                    {
                        Console.WriteLine("e kamuoliukas lengvesnis");
                    }
                }
            }
            

            Console.ReadKey();
        }
    }
}

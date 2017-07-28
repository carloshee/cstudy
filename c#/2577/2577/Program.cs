using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2577
{
    class Program
    {
        static int mul_09(int a, int b, int c)
        {
            int mul = a * b * c;
            int[] num = new int[10];            

            while (mul != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == (mul % 10))
                    {
                        num[i]++;
                        mul /= 10;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int a = 150, b = 266, c = 427, num = 0;
            num = mul_09(a, b, c);

            int n = 1893 % 10;

            Console.WriteLine(n);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex
{
    class Program
    {
        static int pac(int number)
        {
            if (number < 2)
                return 1;
            else
                return number * pac(number - 1);
        }

        static int eq(int s)
        {
            int temp = 0;
            int five = 0;
            int two = 0;
            for (int i = 2; i <= s; i++)
            {
                temp = i;
                while (temp % 2 == 0 || temp % 5 == 0)
                {
                    if (temp % 2 == 0)
                    {
                        temp /= 2;
                        two++;
                    }
                    if (temp % 5 == 0)
                    {
                        temp /= 5;
                        five++;
                    }
                }

            }

            Console.WriteLine(two);
            Console.WriteLine(five);
            return (two < five) ? two : five;
        }

        static void Main(string[] args)
        {
            int num = 0, eqeq = 0, n = 10;
            num = pac(n);
            eqeq = eq(n);
            Console.WriteLine(eqeq);
            //int a1 = int.Parse(num);
        }
    }
}

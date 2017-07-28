using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace exexex
{    

    class Program
    {
        static public int[] arr = new int[10000];

        static int calculate(int n)
        {
            int result = n;

            while (n != 0)
            {
                result =+ (n % 10);
                n /= 10;
            }
            arr[result] = 1;

            return 0;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
            {
                calculate(i);

                if (arr[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}

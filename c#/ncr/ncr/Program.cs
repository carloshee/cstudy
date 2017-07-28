using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ncr
{
    
    class Program
    {
        static ulong ncr(ulong a, ulong b)
        {
            ulong result = 0;

            result = nFactori(a) / (nFactori(b) * nFactori(a - b));

            return result;
        }

        static ulong nFactori(ulong n)
        {
            ulong num = n;

            if (num < 2)
                return 1;
            else
                return num * nFactori(num - 1);
        }

        static void Main(string[] args)
        {
            ulong n = 20;
            ulong r = 6;
            ulong num = 0;
            num = ncr(n, r);

            Console.WriteLine(num);
        }
    }
}

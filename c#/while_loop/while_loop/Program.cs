using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_loop
{
    class Program
    {
        // 1 3 5 7 9 11 13 15
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 15)
            {
                Console.WriteLine("값:" + i);
                i += 2;
            }

            int j = 1;

            do
            {
                Console.WriteLine("값:" + j);
                j += 2;
            } while (j <= 15);
            //do
            //{}
            //while();


            //while(조건) >---- true false
            /*
            while (true) // c true - bool - 1(int) c# true - bool
            {

            }
            */
        }
    }
}

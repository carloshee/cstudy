using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 82;

            if (num >= 90)
                Console.WriteLine("A");
            else if (num >= 80)
                Console.WriteLine("B");
            else
                Console.WriteLine("C");


            switch (num / 10)
            {
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }

        }
    }
}

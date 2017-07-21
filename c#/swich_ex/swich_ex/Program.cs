using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace swich_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            num = num % 5;
            switch (num)
            {
                case 1:
                    Console.WriteLine("나머지는 1");
                    break;
                case 2:
                    Console.WriteLine("나머지는 2");
                    break;
                case 3:
                    Console.WriteLine("나머지는 3");
                    break;
                case 4:
                    Console.WriteLine("나머지는 4");
                    break;
                default:
                    Console.WriteLine("나머지는 0");
                    break;
            }

        }
    }
}

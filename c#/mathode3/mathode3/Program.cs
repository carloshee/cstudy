using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathode3
{
    class Program
    {
        //factorial => 5! = 5*4*3*2*1 = ?
        static uint factorial(uint number)
        {
            if (number <= 1)
                return 1;
            else
            {
                return number * factorial(number - 1);
            }
        }

        static void Main(string[] args)
        {
            //재귀메서드..
            //매서드 내에서 메서드를 호출(자기 자신(혼재 본인메서드 ) ) 호출
            //=> 끝이 있어야 한다. 없으면... 무한루프

            uint result;
            result = factorial(5);
            Console.WriteLine("5! = 5*4*3*2*1 => " + result);
        }
    }
}

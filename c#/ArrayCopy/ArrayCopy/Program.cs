using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열의 복사1 => 같은 공간을 공유
            long[] origin = new long[4] { 1, 2, 3, 4 };
            long[] copy = origin;
            Console.WriteLine("1:" + copy[3]);
            origin[3] = 12345;
            Console.WriteLine("2:" + origin[3]);
            Console.WriteLine("2_2:" + copy[3]);


            int[] a = { 5, 4, 3, 2, 1 };
            int[] clone = (int[]) a.Clone();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("값" + a[i]);
            }
            Console.WriteLine("---------------------------------");
            clone[2] = 33;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("변경된 배열값" + a[i]);
            }
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("변경된 배열값" + clone[i]);
            }
        }
    }
}

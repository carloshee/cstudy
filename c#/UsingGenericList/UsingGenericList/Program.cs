using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int element in list)
                Console.Write("{0} ", element);
            Console.WriteLine();

            list.Remove(2);

            foreach (int element in list)
                Console.Write("{0} ", element);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int elemnet in list)
                Console.Write("{0} ", elemnet);
            Console.WriteLine();
        }
    }
}

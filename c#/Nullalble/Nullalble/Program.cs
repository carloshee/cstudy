using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullalble
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
            Console.WriteLine(a);
        }
    }
}

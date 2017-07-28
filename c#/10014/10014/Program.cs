using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10014
{
    class Program
    {
        
        static int div(int[] n, int length)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += n[i];
            }
            return sum / length;
        }

        static int mid(int[] n, int length)
        {
            int temp = 0;
            for (int j = 0; j < length; j++)
            {
                for (int i = 1; i < length; i++)
                {
                    if (n[i - 1] > n[i])
                    {
                        temp = n[i - 1];
                        n[i - 1] = n[i];
                        n[i] = temp;
                    }
                }
            }
            return n[length/2 - 1];
        }

        static int n_num(int[] n, int length)
        {
            int num = 0, count = 0, temp = 0;
            int[] nn = new int[length];
            for (int j = 0; j < length; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (n[i] == n[j])
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        nn[j]++;
                        count = 0;
                    }
                }
                if (nn[j] > temp)
                {
                    temp = nn[j];
                }
            }
            return n[temp];
        }

        static int range(int[] n, int length)
        {
            int max = 0, min = 0;
            for (int i = 0; i < length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
                if (n[i] < min)
                {
                    min = n[i];
                }
            }
            return max - min;
        }
        
        static void Main(string[] args)
        {
            int num = 0, length = 0;
            int[] n = new int[6] { 5, 1, 3, 8, -2, 2 };
            length = n.Length; 

            num = div(n, length);
            Console.WriteLine(num);

            num = mid(n, length);
            Console.WriteLine(num);

            num = n_num(n, length);
            Console.WriteLine(num);

            num = range(n, length);
            Console.WriteLine(num);
        }
    }
}

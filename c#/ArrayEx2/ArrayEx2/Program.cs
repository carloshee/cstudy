using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 1, 2, 3 }; // 1차원
            int[,] b = new int[2, 3]
            {   //2차원
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[][] c = new int[3][]; //재그배열
            c[0] = new int[3] { 10, 20, 30 };
            c[1] = new int[2] { 40, 50 };
            c[2] = new int[1] { 60 };

            Console.WriteLine("{0}, {1}, {2}", c[0][0], c[0][1], c[0][2]);
            Console.WriteLine("{0}, {1}", c[1][0], c[1][1]);
            Console.WriteLine("{0}", c[2][0]);

            int[][] d = new int[][] { new int[] { 10, 20, 30 },
                                      new int[] { 40, 50 },
                                      new int[] { 60 }
                                    };
            //총개수
            Console.WriteLine("{0},     {1}", a.Length, b.Length); //length : 배열의 길이

            int[] array1 = new int[4];
            int[,] array2 = new int[2, 3];
            int[,,,] array3 = new int[2, 4, 3, 2];

            Console.WriteLine("1번째배열" + array1.Rank); //rank 배열의 차원을 알려줌
            Console.WriteLine("3번째배열" + array3.Rank);
            Console.WriteLine("2번째배열" + array2.Rank);
        }
    }
}

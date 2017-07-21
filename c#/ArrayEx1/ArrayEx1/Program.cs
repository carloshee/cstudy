using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열변수 length => 전체 배열의 갯수를 구한다.
            int[] arrdata2 = new int[5];
            Console.WriteLine(arrdata2.Length);  //배열의 갯수

            int[,] arrdata3 = new int[3, 5];
            Console.WriteLine(arrdata3.Length);  //배열의 갯수


        }
    }
}

/*
//배열 array
//같은 형태의 여러개의 자료형을 하나의 이름으로 정의해서 사용하는것
//int[] a = new int[5];  //int a[5];
//1. 배열형 변수 선언 ... 2. 갯수나 값의 초기화
int[] num; //데이터형 [] 배열명
num = new int[5]; //초기화 new 데이터형[갯수]   => 배열변수에 할당 //new 라고 나오면 0으로 초기화
            //초기화
            num[0] = 111;
            num[1] = 222;
            num[2] = 333;
            num[3] = 444;
            num[4] = 555;
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("배열->" + num[i]);
            }

            //int a[5] => int []a = new int[5];
            //int a[5] = {}, 
            int[] num2 = { 486, 123, 999, 777, 888 };
            for (int i = 0; i< 5; i++)
                Console.WriteLine("배열->" + num2[4]);

            Console.WriteLine("");

            float[] n = new float[3];
            for (int i = 0; i< 3; i++)
            {
                n[i] = 373.3f + i;
                Console.WriteLine(n[i]);
            }

            Console.WriteLine("");

            float[] n2 = { 373.3f, 234.56f, 4539.343f };
            for (int i = 0; i< 3; i++)
            {
                Console.WriteLine(n2[i]);
            }


            //배열에 있어서 표준적으로 사용하는 기능은
            //Array 기능(배열)   사용

            int[] num = { 3, 2, 1, 6, 7, 9, 8 };
            Array.Sort(num);           //정렬
            for (int i = 0; i < 7; i++)
                Console.Write("   " + num[i]);


            
            //다차원 배열
            int[] num;
            int[,] num3;
            int[,,] num4;
            num = new int[2];       //[][]
            num3 = new int[2, 3];   
            //[][][]
            //[][][]
            num4 = new int[2, 3, 4];
            //[] - [][][][]
            //     [][][][]
            //     [][][][]

            //[] - [][][][]
            //     [][][][]
            //     [][][][]
            
            int count = 3;
            int[] num5 = new int[count];
            for (int i = 0; i < num5.Count<int>(); i++)
                Console.WriteLine("갯수" + num5[i]);
             

            //다차원 배열
            int[] num;
            int[,] num3;
            int[,,] num4;
            num = new int[2];       
            //[][]

            num3 = new int[2, 3];
            //[][][]
            //[][][]

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + num3[i, j]);
                }
                Console.WriteLine("");
            }

            num4 = new int[2, 3, 4];
            //[] - [][][][]
            //     [][][][]
            //     [][][][]

            //[] - [][][][]
            //     [][][][]
            //     [][][][]


            //사용자에게 배열의 인자를 입력받아서  행? 열?
            //해당크기만큼의 2차원배열 만들고 값을 출력 할것.

            Console.Write("배열 입력 : ");
            string num = Console.ReadLine();
            Console.Write("배열 입력 : ");
            string num2 = Console.ReadLine();

            int[,] num3 ;
            int a1 = int.Parse(num);
            int a2 = int.Parse(num2);
            num3 = new int[a1, a2];

            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a2; j++)
                {
                    Console.Write(" " + num3[i, j]);
                }
                Console.WriteLine("");
            }

            

*/

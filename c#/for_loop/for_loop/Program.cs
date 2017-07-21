using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_loop
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i*j));
                }
                Console.WriteLine("");
            }


            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 1; i < 6; i++)
            {
                for (int k = i; k < 5; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

//for 문
//횟수제한이 있는 반복문에 사용을 한다.
/*
            int i = 3;
            //객체지향 언어에서 자료형은 필요할때 생성해서 사용한다.
            //자료형의 적용범위는 선언 이후부터 해당 영역이 끝날때까지...
            for (; i <= 5;) //해당 세팅부는 필요에 따라 생략이 가능하다.
                //초기값, 조건식(반목문 탈출을 위해 증감식(반복탈출을 위한 값의 변경)
            {
                Console.WriteLine("출력");
                i++;
            }
            Console.WriteLine("출력==>" + i);
 */

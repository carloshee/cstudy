using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//일반화
//공통자료형.. 어떤 자료형이든지 올 수 있도록 기호화 한 키워드
// T : template 단어의 약어
//일반화 메서드
//함수에 사용되는 자료형을 공통자료형으로 세팅한 메서드
//리턴타입 메서드명 <T> (파라미터) // T형 변수
namespace Generk01
{
    class Program
    {
        static void calcurate<T>(T x, T y)
        {
            Console.WriteLine(x + "+" + y);
        }

        static void Main(string[] args)
        {
            calcurate<int>(10, 20);
            calcurate<string>("10", "20");
            calcurate<float>(3.1f, 4.2f);

            SwapTest1();
            SwapTest2();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        static void SwapTest1()
        {
            int a = 1;
            int b = 2;
            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + "," + b);
        }

        static void SwapTest2()
        {
            string a = "aaa";
            string b = "bbb";
            Swap<string>(ref a, ref b);
            System.Console.WriteLine(a + "," + b);
        }
    }
}
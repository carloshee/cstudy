using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathod_1
{
    // 메서드 : 프로그램 내 에서 결과를 도출하는 로직을
    // 특정한 이름으로 정의한것.
    // 형식
    // c# 접근권한 변수처럼 
    class Program
    {
        int numdata(int x)
        {
            int ret = 3;
            return ret;
        }

        void main2()
        {
            numdata(3);
        }

        //public, protected, private
        public static int add_data(int a, int b) // 넘겨지는 자료형이 어디에서 쓰이는가?
        {
            int ret = 0;
            ret = a + b;
            return ret;
        }

        public static float add_data(float a, float b)
        {
            float ret = 0;
            ret = a + b;
            return ret;
        }

        public static string add_data(string a, string b)
        {
            string ret = null;
            ret = a + b;
            return ret;
        }

        //함수의 중복정의 (overload)
        // 컴파일러가 메서드를 인식할때 .. 
        //이름으로 인식하는가? 파라미터로 인식하는가?
        //c 언어는 이름으로 인식 .. 메서드 이름은 중복x => unique
        //c# 언어는 파라미터타입을 가지고 인식
        //파라미터가 다르다면 같은 이름의 메서드를 사용해도 무방하다

        // 정수... 실수.. 문자.. 
        static void Main(string[] args) //static.. 자료타입이 정적
                                        //종료가 되기전 메모리상에 계속 존재하는.
                                        //호출하는 메서드는 해당영역의 자료타입에 맞추어야 한다.
        {
            int num1, num2, num3;
            float num4, num5, num6;
            string c1, c2, c3;
            num1 = 123; num2 = 456; num3 = 0; num4 = 0; num5 = 12.3f; num6 = 45.3f;
            c1 = "a"; c2 = "b"; c3 = null;
            // 두수를 더하는 기능을 새로 정의
            num3 = add_data(num1, num2);//함수의 호출.. c, c# 동일
            num4 = add_data(num5, num6);
            c3 = add_data(c1, c2);

            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(c3);

        }
    }
}

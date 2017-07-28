using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Object a = 3.14f;
            int b = 123;
            int c = b;              //데이터와 더불어 형태가 정해진 자료형 그냥 할당이 가능.
            float d = (float) a;    //a 변수는 값만 들어가 있음 => 자료형의 종류는 세팅이 안되어 있음
                                    //변수의 값을 넣는다 (박싱.         언박싱)
                                    //데이터 세팅 자료형타입 알려줌

            Console.Write("값은 {0} {1}", c , d);
        }
    }
}

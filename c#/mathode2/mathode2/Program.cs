using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathode2
{
    class Program
    {
        //C 언어.. 메서드를 선언(형태를 정의하다.: 메모리 사용안함
        // 메서드가 어떻게 작동되는지 로직만 작성)
        //메서드 작성순서도 중요...
        // main 상단부에 ... 메서드가 위치... 메서드 로직 비대화...
        // 실제 메인로직의 수정 어려워 -> 메서드 프로토 타입..
        //메서드를 선언부와 비슷하게 .. {} 없이 재정의 끝에 ;
        //static void mathodeB()..

        // c# 메서드가 정의가 되어 있으면 어디서는 호출이 가능함.
        // 메서드 정의 위치는 중요하지 않다.
        // 메서드 정의위치 중요X 메서드 정의가 되어 있는가?
        //=>메서드의 프로토 타입이 필요없다.

        static void Main(string[] args)
        {
            mathodeB();
            mathodeA();
        }

        static void mathodeB()
        {
            mathodeA();
            Console.WriteLine("B 메서드임");
            mathodeA();
            Console.WriteLine("--------------");
        }

        //중첩 메서드 : 호출된 메서드 내에서 다른 메서드를 호출해서 사용할 수 있다.
        static void mathodeA()
        {
            Console.WriteLine("A 메서드임");
        }
    }
}

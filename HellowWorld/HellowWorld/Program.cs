using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HellowWorld // 작업영역 // 다른영역에 기능을 정의 
{
    class Program
    {
        static void Main(string[] args)
        {
            //printf()
            //System.Out.Printfln();
            //화면에 글자 및 데이터 출력
            Console.Write("윤하 ");  // 문자 출력
            //printf("윤하");

            Console.WriteLine(123); // 숫자 출력
            Console.WriteLine("비밀번호486");
            //printf(윤하 \n);
            //ctrl + shift + b
            //데이터와 문자열을 같이 출력하는 방법.....
            Console.WriteLine("가나다라" + 12345);
            Console.WriteLine("abcd {0} {1} {2}", 98765, "defg", 13579);
            Console.WriteLine("abcd " + 98765 + " defg " + 13579);
            Console.WriteLine("펜" + "파인애플" + "애플" + "팬");


            //절차지향언어(c)    정의부, 연산부가 구분되어야 한다.
            //정의
            //연산 메서드

            //객체지향언어 // 필요에 따라서 그때그때 데이터를 정의할 수 있다.
            int num = 333;
            Console.WriteLine(num);
        }
    }
}

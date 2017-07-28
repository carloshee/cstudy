using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Program
    {
        static int numdata = 33;
        static void var_data()
        {
            int a = 123; //지역변수
            int b = 486; //
            a++;
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            var_data();
            var_data();
            Console.WriteLine(numdata);
        }
    }
}
//메서드내에서 만드는 자료형들은 일반적을 지역변수라 부른다.
//지역 변수 : 특정 영역 안에 만들어진 변수로 해당영역을
//벗어나면 변수는 자동으로 파괴된다.

    //cf) static 정적
    //메모리 공간의 정적 => 메모리 공간을 만들고 해당 공간을 재사용한다.
    //static 변수         -> 호출                            ->호출
    // 공간을 생성       값의 변경                              반환안한 공간을 재사용( o )
    //값 세팅           값이 없을때 초기화                      초기화세팅은 하지않음
    //                  메서드는 저장공간을 반환하나             값의 변경은 가능
    //                  정적 자료형은 저장공간을 반환안함
    //                  초기화가 된 경우 다시 초기화를 하지는 않음
    //결론 : 지역변수처럼 만들어지나 => 내부형태나 사용은 전역변수처럼 사용할 수 있다.
    //사용처 : 어디에서 사용을 하는가?
    // main루틴이 존재하는경우 ... static 변수를 사용해도 사용안해도 무방
    //main루틴이 존재안하는 경우.
    //class 나 struct만 있는경우 ... main() 없는경우들은
    //전역변수를 만들 수 없다.
    // =>  프로그램에서 데이터가 끝까지 유지가 안된다. 상황에 따라 다 삭제가 됨.
    // static 기호를 통한 변수(자료형)을 만들어서.. 전역변수처럼 사용한다. 
    //main 루틴외공간에서 전역자료형을 만드는 방법





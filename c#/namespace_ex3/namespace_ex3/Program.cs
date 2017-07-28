using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//사용자 정의
using Tokyo;
using Tokyo.Tosima; // 각 영역별로 ... namespace 

namespace Tokyo
{
    class Tokyotower
    {
        public void print()
        {
            Console.WriteLine("도쿄타워 입니다.");
        }
    }
    namespace Tosima
    {
        class sunshine
        {
            public void print()
            {
                Console.WriteLine("선샤인60");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 생성이 너무 빡셈
        // 생성을 좀 쉽게 하고 싶은데...
        // 네임스페이스를 미리 등록 => 알아서 내부의 데이터(클래스) 접근할 수 있다.
        // using -> 해당 namespace 영역에 있는 다양한 클래스나 메서드나 자료형을 쓰겠다.
        // 사용법
        // using namespace;         // using 다음에는 네임스페이스만 올 수 있다.
                                    // 프로그램 시작 전에 먼저 선언해 준다.
                                    // 내가 선언한 네임스페이스 내의 영역 => 클래스나 메서드만...
                                    // 내부에 있는 네임스페이스는 안 보여줌.

        Tokyo.Tokyotower tower = new Tokyo.Tokyotower();
        Tokyo.Tosima.sunshine sn = new Tokyo.Tosima.sunshine();

        Tokyotower tower2 = new Tokyotower(); ///
        sunshine sn2 = new sunshine();

        tower.print();
        sn.print();
    }
}

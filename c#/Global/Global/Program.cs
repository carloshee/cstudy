using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//클래스내에 정적 자료형을 만들었을때
//형식
//클래스{
//정적자료형의 선언과 초기화
//}
//사용
//클래스.      선언된 자료형
//특정영역      변수를 사용
class Player
{
    static public int m_gold = 0; // 저장공간을 만들고 ... 값을 초기화
    static public int m_score = 1; // 전역변수로 선언되지는 않았지만 전역변수처럼 사용
}

struct player2
{
    public int m_gold;
    public int m_score;

}

namespace Global
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Global.count : {0}", Global.Count);

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine("Global.count : {0}", Global.Count);

            player2 player2;
            player2.m_score = 100;
            player2.m_gold = 100;

            Console.WriteLine("값은" + Player.m_gold);
            Player.m_gold += 100;
            Player.m_score += 1000;
            //영역, 변수 => 구조체나 포인터의 멤버 느낌.
                            //특정영역에 있는 변수를 사용.

            Console.WriteLine("값은" + Player.m_gold + "값은" + Player.m_score);
        }
    }
}

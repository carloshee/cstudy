using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// namespace :
// 다중 작업을 통해 프로젝트 구성시
// 클래스(메서드)의 중복이 생길 수 있다.
// 해당 클래스를 구분지을 수 있는 영역을 만들어 클래스를 제작하면
// 중복이나 모호성을 해소할 수 있다.   => namespace
// => 같은 이름의 클래스가 있어도 충돌 안나게
/*
 
 형식
 //선언...
 namespace 영역이름
 {
    클래스를 구현
 }
    
 사용
 영역이름.클래스명 변수  = new 영역이름.클래스명();
 //namespace 를 이용한 객체는 해당 namespace(영역이름)을 명시해야 한다.
 => 네임스페이스 내에 정의된 클래스를 참조할때 연산자를 . 사용한다.
 */

// 서로 다른 namespace 1:1 

namespace AA
{
    class carddata
    {
        public int m_a = 3;
    }
}

namespace BB
{
    class carddata
    {
        public int m_a = 5;
    }
}

//namespace 내에 namespace가 들어갈 수 있는가?
//중첩해서 사용할 수 있다.
// 사용은?
//
namespace CC
{
    class carddata
    {
        public int m_a = 1;
    }
    namespace DD
    {
        //cc.dd
        class carddata
        {
            public int m_a = 8;
        }
    }
}

namespace namespace_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //carddata.a;// error 영역을 명시안해서
            AA.carddata a = new AA.carddata();
            BB.carddata b = new BB.carddata();
            //사용은 기존과 동일
            Console.WriteLine("{0}  {1}", a.m_a, b.m_a);

            CC.carddata c = new CC.carddata();
            CC.DD.carddata d = new CC.DD.carddata();
            Console.WriteLine("{0}  {1}", c.m_a, d.m_a);
        }
    }
}

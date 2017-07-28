using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_ex1
{
    //구조체.. 사용자 정의 자료형...
    //형식
    /*
    struct 자료형 이름
    {
        멤버데이터
    }
     */
    //사용
    //자료형이름 변수
    //변수, 멤버
    struct Hero
    {
        //내부를 접근할때 보호 수준이 있다. (접근권한)
        //public, protected, private
        public int hp;
        public int mp;

        public void init_data()// C# 기능도 넣을 수 있다.(메서드)
        {
            hp = mp = 300;// 저장공간이 있는가?
        }//선언부인경우에는 저장공간이 없음

        public void print()
        {
            Console.WriteLine("aaa{0}bbb{1}", hp, mp);
        }
  
    class Program
    {
        // 구조체 외부...
        static void Main(string[] args)
        {
            //직접접근 => 변수처럼 가져다 씀
            Hero ironman; //=> 자료형을 선언...
            // 멤버를 집접 접근... 값 세팅 => 일반변수처럼 사용이 됨...
            ironman.hp = 100; 
            ironman.mp = 100;
            Console.WriteLine("aaa{0}bbb{1}", ironman.hp, ironman.mp);
            //내부에 있는 메서드를 쓰고 싶은 구조체
            //간접접근 (저장공간을 만들고... 해당 주소를 받음)
            Hero spideman = new Hero();
            // Hero *Spiderman = Malloc(sizeof(Hero));
            spideman.init_data();
            spideman.print();
        }
    }
}

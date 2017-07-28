using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_ex1
{
    //객체 (데이터, 메서드)
    //형식
    /*
     * class 객체명
     * {
     *  정보(자료형)선언
     *  //멤버변수
     *  기능 선언
     *  //멤버메서드
     * }인스턴스 멤버 oop
     */
    class Hero      //클래스 만든것... 자료형 선언...
    {
        //권한세팅
        //사용법... 권한.. 자료형 변수                   -변수
        //          권한   리턴타입 메서드명(파라미터)   -메서드
        public int mp;
        public int hp;
        public int lv;
        public bool alive;
        public void initial()
        {
            lv = 1;
            hp = mp = 10;
            alive = true;
        }
        public void now_dead()
        {
            hp = 0;
            mp = 0;
            alive = false;
        }
        public void now_leveup()
        {
            lv += 1;
            hp += 10;
            mp += 5;
            alive = true;
        }
        public void showstate()
        {
            Console.WriteLine("lv:" + lv);
            Console.WriteLine("hp:" + hp);
            Console.WriteLine("mp:" + mp);
            Console.WriteLine("state 1:live 0:dead ->" + alive);
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {

            // 내부의 데이터를 사용할때 . 연산자...
            // 변수, 내부정보

            // 멤버 에러발생... 클래스영역을 벗어난 상태에서 내부정보를 
            // 사용할때는 , 그 상황에 맞는 권한을 설정...
            // public, private, protected

            // 객체변수 에러발생
            // 객체의 선언과 사용은 변수의 형태와는 다르다.
            // 변수.. 크기와 형태가 정해졌음.
            // 선언과 동시에 바로 사용할메모리가 만들어지고.. 바로 사용가능
            // 클래스 변수 : 크기와 형태가 제각각(사용자정의)
            // 별도로 메모리를 할당을 해야 한다..
            // 메모리 할당 키워드 new 
            // 해당 자료형크기만큼 할당
            // new 자료형() => 비슷한 뉘앙스 malloc(sizeof(자료형));
            // new <-> delete                 malloc <-> free
            // 객체 메모리를 얻고 주소기준으로 접근...
            // 간접접근 => 클래스는 간접접근 방식...(주소로 접근)
            // 하지만 ... 주소 자료형을 숨겨 놓았기 때문에
            // 겉으로 보면 직접접근으로 보임...

            Hero linx;
            linx = new Hero();

            linx.hp = 20;
            linx.showstate();
            linx.initial();
            linx.now_leveup();
            linx.showstate();
            linx.now_leveup();
            linx.showstate();
            linx.now_dead();
            linx.showstate();

            //delete()? 없어?  => c#, java 메모리관리를 시스템에서 알아서 해줌.
            //따라서 delete 구문이 불필요..
            //가비지 콜렉션
        }
    }
}

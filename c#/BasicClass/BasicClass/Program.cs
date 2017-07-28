using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicClass
{
    class Temp
    {
        // 접근권한... 클래스 내부에서는 모든 데이터의 접근이 가능하다.
        // 하지만 클래스 외부에서는?
        // 만약 현재 클래스를 기분으로 기능을 추가 했다면
        // 기능 추가한 클래스는 기반 클래스의 자료형을 쓸 수 있는가?
        // public       private         protected
        //외 o           x                   x       (해당 클래스를 기반으로 => 기능추가된 클래스는... 접근이 가능 => 상속의 개념)
        //내 o           o                   o   
        //oop의 특징 - (캡슐화 은닉화)...  상속, 다형성
        public int a;
        private int b;
        protected int c;
        int d; //아무것도 안쓰면 private 속성을 가진다.
    }

    class cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Temp a = new Temp(); // 클래스 생성... 메로리할당
            //a.d = 33;

            cat Kitty = new cat();
            Kitty.Color = "하얀색";
            Kitty.Name = "키티";
            Kitty.Meow();
            Console.WriteLine("{0} : {1}", Kitty.Name, Kitty.Color);

            cat nero = new cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero.Name, nero.Color);
        }
    }
}

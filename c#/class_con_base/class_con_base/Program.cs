using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
class calcl
{
    public int x;
    public calcl(int a, int b)
    {
        x = a + b;
    }
}

class calcl2 : calcl
{
    //상속시 원본의 생성자를 호출할때 base 키워드를 쓴다. << class 시 에는 이렇게 class안의 메소드는 this로
    public calcl2(int c, int d) : base(c, d)
    {
        x = c + d;
    }    
}

class Program
{
    static void Main(string[] args)
    {
        calcl2 cx = new calcl2(1, 2);
        Console.WriteLine(cx.x);
    }
}

    */

class A
{
    public int a = 3;
}

class B : A
{
    public int a = 100;
    public void print()
    {
        Console.WriteLine(a);
        Console.WriteLine(base.a);   //부모객체의 접근 키워드 base
    }
}

class Program
{
    static void Main()
    {
        B b = new B();
        b.print();
    }
}
